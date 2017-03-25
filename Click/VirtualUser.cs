using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click
{
    public class VirtualUser
    {
        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;

        private const uint KEYEVENTF_KEYUP = 0x0002;
        private const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        public int GetAlmountPoints()
        {
            throw new NotImplementedException();
        }
        
        public void RemoveSeries()
        {
            throw new NotImplementedException();
        }

        public void AddPointToSeries(Point p)
        {
            throw new NotImplementedException();
        }

        public void ExecuteSeries()
        {
            throw new NotImplementedException();
        }

        public void ClickLeftMouse()
        {
            uint x = (uint) Cursor.Position.X;
            uint y = (uint) Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, (uint)0, (uint)0);
        }

        public void ClickLeftMouse(int x, int y)
        {
            Cursor.Position = new Point(x, y);
            ClickLeftMouse();
        }

        public void PressKey(Keys key)
        {
            keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
        }

        public void ReleaseKey(Keys key)
        {
            keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        public void MoveMouseSmoothToTime(int x, int y, float time)
        {
            throw new NotImplementedException();
        }

        public void MoveMouseSmoothToSpeed(int x, int y, float speed)
        {
            throw new NotImplementedException();
            //speed = distance / time

            //MoveMouseSmoothToTime(x,y,  )
        }

    }
}
