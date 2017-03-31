using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Click
{
    struct ClickPoints
    {
        public Point Point;
        public float Time;
        public Keys Key;// = Keys.None;

        public override string ToString()
        {
            return $"Point {Point} Or Key {Key} At {Time}";
        }
    }

    public class VirtualUser
    {
        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;

        private const uint KEYEVENTF_KEYUP = 0x0002;
        private const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        private List<Point> points;
        private List<ClickPoints> clickPoints;
        private readonly Random r = new Random();

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo); 
        //TODO mouse_event is depricated gebruik SendInput

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        //TODO gebruik SendInput

        public int GetAlmountPoints()
        {
            //return points?.Count ?? 0;
            return clickPoints?.Count ?? 0; //TODO haal de oude points weg
        }
        
        public void RemoveSeries()
        {
            points = new List<Point>();
            clickPoints?.Clear();
        }

        public void AddPointToSeries(Point p)
        {
            if (clickPoints == null)
            {
                clickPoints = new List<ClickPoints>();
            }

            if (points == null)
            {
                points = new List<Point>();
            }

            clickPoints?.Add(new ClickPoints() {Point = p, Time = DateTime.Now.ToFileTimeUtc()}); //TODO voeg de tijd toe, deze is relatief aan de laatste click voor deze click
            points?.Add(p);
        }

        public void AddKeyToSeries(Keys key)
        {
            if(clickPoints == null)
            {
                clickPoints = new List<ClickPoints>();
            }
            clickPoints?.Add(new ClickPoints() { Key = key,  Time = DateTime.Now.ToFileTimeUtc() });
        }

        public void ExecuteSeries()
        {
            foreach (Point point in points)
            {

                ClickLeftMouse(point.X, point.Y);
                int sleep = 100 - r.Next(20);
                Thread.Sleep(sleep);
            }
        }

        public void ExecuteSeries(ref bool isPlaying)
        {
            isPlaying = true;
            Point p = Cursor.Position;
            /*foreach (Point point in points)
            {
                ClickLeftMouse(point.X, point.Y);
                int sleep = 100 - r.Next(20);
                Thread.Sleep(sleep);
            }*/
            foreach(ClickPoints cp in clickPoints)
            {
                if(cp.Key != Keys.None)
                {
                    PressKey(cp.Key);
                }
                if (cp.Point != Point.Empty)
                {
                    ClickLeftMouse(cp.Point.X, cp.Point.Y);
                }
                int sleep = 100 - r.Next(20);
                Console.WriteLine(cp.ToString());
                Thread.Sleep(sleep);
            }
            isPlaying = false;
            Cursor.Position = p;
        }

        public void ClickLeftMouse()
        {
            var x = (uint) Cursor.Position.X;
            var y = (uint) Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }

        public void ClickLeftMouse(int x, int y)
        {
            Cursor.Position = new Point(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
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
