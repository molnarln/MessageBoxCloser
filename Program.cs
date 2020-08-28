using System;
using System.Runtime.InteropServices;

namespace MessageBoxCloser
{
    class Program
    {
        static void Main(string[] args)
        {
            var window = Class1.FindWindow(null, "Ez a gép");
            while (window != IntPtr.Zero)
            {
                Class1.CloseWindow(window);
                window = Class1.FindWindow(null, "Ez a gép");

            }
            Console.WriteLine("Press a button to quit");
            Class1.MessageBox(IntPtr.Zero, "Ablakok bezárva", "Done - Message", 0x00000000);
        }
    }
}
