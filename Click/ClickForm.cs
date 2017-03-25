using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Click
{
    public partial class clickForm : Form
    {
        //TODO haal alle on nodige dingen weg
        //TODO verplaats meer naar een andere classe voor een meer gescheide gui/logic
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private const uint KEYEVENTF_KEYUP = 0x0002;
        private const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
        private bool expectInput;
        private bool setPlayButton;

        private KeyHandler ghk;

        private List<Point> clickPoints;
        private bool mouseRecording;
        private bool playing;

        private Point lastPoint;

        private KeyboardHook kbhook;
        private KeyboardHook.VKeys startRecording;
        private KeyboardHook.VKeys clickMouse;

        public clickForm()
        {
            InitializeComponent();

            lbl_btn.Text = KeyboardHook.VKeys.F6.ToString();
            lbl_Recording_Start.Text = KeyboardHook.VKeys.DOWN.ToString();
            clickMouse = KeyboardHook.VKeys.F6;
            startRecording = KeyboardHook.VKeys.DOWN;
            clickPoints = new List<Point>();

            StaticMouseHook.SetMouseDelegate(mousehookEvent);
            StaticMouseHook.SetMouseDelegate(mousehookEventFastClick);
            //TODO maak deze classe niet private

            WindowState = FormWindowState.Minimized;
            kbhook = new KeyboardHook();
            kbhook.Install();
            kbhook.KeyDown += KbhookOnKeyDown;
        }

        private void KbhookOnKeyDown(KeyboardHook.VKeys key)
        {
            //TODO Clean dit op
            if (expectInput)
            {
                clickMouse = key;
                lbl_btn.Text = key.ToString();
                expectInput = false;
            }
            if (mouseRecording)
            {
                if (key == KeyboardHook.VKeys.ESCAPE)
                {
                    StaticMouseHook.RemoveMouseDelegate(mousehookEvent);
                    mouseRecording = false;
                }
            }
            if (setPlayButton)
            {
                startRecording = key;
                lbl_Recording_Start.Text = key.ToString();
                setPlayButton = false;
            }

            if (key == startRecording)
            {
                if (!playing)
                    playRecording();
            }

            if (key == clickMouse)
            {
                if (cb_Alt.Checked)
                    PressKey(Keys.Alt);

                if (cb_Shift.Checked)
                    PressKey(Keys.ShiftKey);

                if (cb_Ctrl.Checked)
                    PressKey(Keys.ControlKey);

                for (var i = 0; i < nud_Clicks.Value; i++)
                    DoMouseClick();

                if (cb_Alt.Checked)
                    ReleaseKey(Keys.Alt);

                if (cb_Shift.Checked)
                    ReleaseKey(Keys.ShiftKey);

                if (cb_Ctrl.Checked)
                    ReleaseKey(Keys.ControlKey);
            }
        }

        private void mousehookEvent(int x, int y)
        {
            clickPoints.Add(new Point(x, y));
            lbl_Clicks.Text = clickPoints.Count + "";
        }

        private void mousehookEventFastClick(int x, int y)
        {
            if (cb_FastClick.Checked)
            {
                //TODO doe fastclick
                DoMouseClick();
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        /// <summary>
        ///     Does a virtual click on the cursor position
        /// </summary>
        private void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            var x = Cursor.Position.X;
            var y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }

        private void DoMouseClick(int x, int y)
        {
            Cursor.Position = new Point(x,y);
            DoMouseClick();
        }

        /// <summary>
        ///     Press a key
        /// </summary>
        /// <param name="key">The keyboard key</param>
        private void PressKey(Keys key)
        {
            keybd_event((byte) key, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
        }

        /// <summary>
        ///     Release a key
        /// </summary>
        /// <param name="key"></param>
        private void ReleaseKey(Keys key)
        {
            keybd_event((byte) key, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        private void btn_rebind_Click(object sender, EventArgs e)
        {
            expectInput = true;
        }

        private void ClickForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (expectInput)
            {
                lbl_btn.Text = Enum.GetName(typeof(Keys), e.KeyCode);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            kbhook.Uninstall();
            StaticMouseHook.unhook();
            base.OnFormClosing(e);
        }

        private void btn_Record_Click(object sender, EventArgs e)
        {
            clickPoints.Clear();
            StaticMouseHook.hook();
            StaticMouseHook.SetMouseDelegate(mousehookEvent);
            mouseRecording = true;
        }

        private void playRecording()
        {
            playing = true;
            lastPoint = Cursor.Position;

            if (clickPoints.Count > 0)
            {
                foreach (var point in clickPoints)
                {
                    Cursor.Position = point;
                    DoMouseClick();
                    Thread.Sleep(100); //TODO maak de 100 veranderbaar en random binnen een marge
                    //TODO Fix de lag die soms ontstaat
                }
            }

            Cursor.Position = lastPoint;
            playing = false;
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            playRecording();
        }

        private void btn_Bind_Recording_Click(object sender, EventArgs e)
        {
            setPlayButton = true;
        }

        private void cb_FastClick_Load(object sender, EventArgs e)
        {
            //TODO implementeer dit
        }
    }
}