using System;
using System.Windows.Forms;

namespace Click
{
    public partial class ClickBetterForm : Form
    {
        private bool canChangeCLickBind;

        private KeyboardHook.VKeys clickBindKey;
        private readonly KeyboardHook kbhook;
        private readonly MouseHook mHook;
        private readonly VirtualUser virtualUser;

        public ClickBetterForm()
        {
            InitializeComponent();

            kbhook = new KeyboardHook();
            kbhook.Install();
            kbhook.KeyDown += ClickBindEvent;
            ChangeClickBind(KeyboardHook.VKeys.F6);

            mHook = new MouseHook();
            mHook.Install();
            mHook.LeftButtonDown += fastClick;

            virtualUser = new VirtualUser();

            WindowState = FormWindowState.Minimized;
        }

        private void fastClick(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            //throw new NotImplementedException();
        }

        private void ClickBindEvent(KeyboardHook.VKeys key)
        {
            if (canChangeCLickBind)
            {
                ChangeClickBind(key);
                canChangeCLickBind = false;
                return;
            }

            if (clickBindKey == key)
                virtualUser.ClickLeftMouse();
        }

        private void btn_RecordClickBind_Click(object sender, EventArgs e)
        {
            canChangeCLickBind = true;
        }

        private void ChangeClickBind(KeyboardHook.VKeys key)
        {
            lbl_ClickBind.Text = key.ToString();
            clickBindKey = key;
        }

        private void btn_BindClickShift_Click(object sender, EventArgs e)
        {
        }
    }
}