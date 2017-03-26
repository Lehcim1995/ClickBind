using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Click;
using Gma.System.MouseKeyHook;

namespace RuneScapeBetterClickker
{
    public partial class Clickker : Form
    {
        private IKeyboardMouseEvents m_Events;
        private VirtualUser vu;

        private bool bindFastClick;
        private bool isFAstClick;
        private bool isPressed;
        private Keys fastClickButton;

        private Keys clickBind;
        private bool bindClickBind;
        private Keys specialClickBind;
        private bool bindSpecialClickBind;

        private Keys playClickRecording;
        private Keys stopRecording = Keys.Escape;
        private bool recordingClicks;
        private bool bindPlayClickRecording;
        private bool playingRecording;

        public Clickker()
        {
            InitializeComponent();

            Subscribe(Hook.GlobalEvents());
            vu = new VirtualUser();

            clickBind = Keys.F6;
            specialClickBind = Keys.F7;

            lbl_ClickBind.Text = clickBind.ToString();
            lbl_SpecialClickBind.Text = specialClickBind.ToString();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Unsubscribe();
            base.OnClosing(e);
        }

        private void Clickker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unsubscribe();
        }

        private void Subscribe(IKeyboardMouseEvents events)
        {
            m_Events = events;

            m_Events.KeyDown += RegisterFastClickButton;
            m_Events.KeyDown += CheckFastKey;
            m_Events.KeyDown += ClickBindKeyPress;
            m_Events.KeyDown += SpecialCickBindPress;
            m_Events.KeyDown += StartClickRecording;
            m_Events.KeyDown += StopRecording;

            m_Events.MouseDownExt += FastClickReg;
            m_Events.MouseUpExt += FastClickUp;
            m_Events.MouseUpExt += SupressKeyResign;
            m_Events.MouseClick += RecordingMouseActivity;
            m_Events.MouseMoveExt += SupressMouseWhilePlaying;
        }

        private void SupressMouseWhilePlaying(object sender, MouseEventExtArgs mouseEventExtArgs)
        {
            mouseEventExtArgs.Handled = playingRecording;
        }

        private void StopRecording(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.KeyCode != stopRecording) return;
            recordingClicks = false;
            keyEventArgs.Handled = true;
        }

        private void StartClickRecording(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.KeyCode != playClickRecording) return;
            if (vu.GetAlmountPoints() == 0) return;
            vu.ExecuteSeries(ref playingRecording);
        }

        private void RecordingMouseActivity(object sender, MouseEventArgs mouseEventArgs)
        {
            if (!recordingClicks) return;
            vu.AddPointToSeries(mouseEventArgs.Location);
            lbl_CLicks.Text = vu.GetAlmountPoints().ToString();
        }

        private void SupressKeyResign(object sender, MouseEventExtArgs mouseEventExtArgs)
        {
            if (bindFastClick || bindClickBind || bindSpecialClickBind)
                mouseEventExtArgs.Handled = true;
        }

        private void SpecialCickBindPress(object sender, KeyEventArgs keyEventArgs)
        {
            if (!cb_Binds.Checked) return;
            if (keyEventArgs.KeyCode != specialClickBind || !bindSpecialClickBind) return;
            vu.PressKey(Keys.ShiftKey);
            vu.ClickLeftMouse(); //TODO voeg de shift code toe
            vu.ReleaseKey(Keys.ShiftKey);
            keyEventArgs.Handled = true;
        }

        private void ClickBindKeyPress(object sender, KeyEventArgs keyEventArgs)
        {
            if (!cb_Binds.Checked) return;
            if (keyEventArgs.KeyCode != clickBind || bindClickBind) return;
            vu.ClickLeftMouse();
            keyEventArgs.Handled = true;
        }

        private void FastClickUp(object sender, MouseEventExtArgs mouseEventExtArgs)
        {
            Console.WriteLine("Up");
            if (!isFAstClick || !isPressed) return;
            isPressed = false;
            Console.WriteLine("FastCLickUp");
            mouseEventExtArgs.Handled = true;
        }

        private void FastClickReg(object sender, MouseEventExtArgs mouseEventExtArgs)
        {
            Console.WriteLine("Down");
            if (isPressed || !isFAstClick) return;
            isPressed = true;
            //vu.ClickLeftMouse();
            Console.WriteLine("FastCLickDown");
        }

        private void CheckFastKey(object sender, KeyEventArgs keyEventArgs)
        {
            if (!cb_FastClick.Checked) return;
            isFAstClick = keyEventArgs.KeyCode == fastClickButton;
            keyEventArgs.Handled = isFAstClick;
        }

        private void RegisterFastClickButton(object sender, KeyEventArgs keyEventArgs)
        {
            if (bindFastClick)
            {
                lbl_FastClickKey.Text = keyEventArgs.KeyCode.ToString();
                fastClickButton = keyEventArgs.KeyCode;
                bindFastClick = false;
                return;
            }

            if (bindClickBind)
            {
                lbl_ClickBind.Text = keyEventArgs.KeyCode.ToString();
                clickBind = keyEventArgs.KeyCode;
                bindClickBind = false;
                return;
            }

            if (bindSpecialClickBind)
            {
                lbl_SpecialClickBind.Text = keyEventArgs.KeyCode.ToString();
                specialClickBind = keyEventArgs.KeyCode;
                bindSpecialClickBind = false;
                return;
            }

            if (bindPlayClickRecording)
            {
                lbl_PlayRecording.Text = keyEventArgs.KeyCode.ToString();
                playClickRecording = keyEventArgs.KeyCode;
                bindPlayClickRecording = false;
                return;
            }
        }

        private void Unsubscribe()
        {
            if (m_Events == null) return;

            m_Events.KeyDown -= RegisterFastClickButton;
            m_Events.KeyDown -= CheckFastKey;
            m_Events.KeyDown -= ClickBindKeyPress;
            m_Events.KeyDown -= SpecialCickBindPress;
            m_Events.KeyDown -= StartClickRecording;
            m_Events.KeyDown -= StopRecording;

            m_Events.MouseDownExt -= FastClickReg;
            m_Events.MouseUpExt -= FastClickUp;
            m_Events.MouseUpExt -= SupressKeyResign;
            m_Events.MouseClick -= RecordingMouseActivity;
            m_Events.MouseMoveExt -= SupressMouseWhilePlaying;

            m_Events.Dispose();
            m_Events = null;
        }


        private void btn_BindFastClick_Click(object sender, EventArgs e)
        {
            bindFastClick = true;
        }

        private void bnt_Bind_Click_Click(object sender, EventArgs e)
        {
            bindClickBind = true;
        }

        private void btn_Bind_SpecialClick_Click(object sender, EventArgs e)
        {
            bindSpecialClickBind = true;
        }

        private void btn_StartRecording_Click(object sender, EventArgs e)
        {
            vu.RemoveSeries();
            recordingClicks = true;
        }

        private void btn_BindStartRecording_Click(object sender, EventArgs e)
        {
            bindPlayClickRecording = true;
        }

        private void cb_Binds_CheckedChanged(object sender, EventArgs e)
        {
            btn_Bind_SpecialClick.Enabled = cb_Binds.Checked;
            btn_Bind_Click.Enabled = cb_Binds.Checked;
        }

        private void cb_Recording_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("We neeed change!");
        }
    }
}