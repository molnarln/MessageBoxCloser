using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoxCloser
{
    public class Class1
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_CLOSE = 0xF060;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        internal static extern int MessageBox(IntPtr hWnd, string lpText, string lpCption, uint uType);

        public static void CloseWindow(IntPtr window)
        {
            if (window != IntPtr.Zero)
            {
                Console.WriteLine("Window found, closing...");

                SendMessage((int)window, WM_SYSCOMMAND, SC_CLOSE, 0);
            }
        }
    }
}

