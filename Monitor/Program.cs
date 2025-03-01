﻿namespace Monitor
{
    class Program
    {
        const int WM_SYSCOMMAND = 0x0112;
        const int SC_MONITORPOWER = 0xF170;
        const int HWND_BROADCAST = 0xFFFF;
        const int MONITOR_POWER_OFF = 2;

        /// <summary>
        /// Sends command to turn monitors off, will be able wiggle mouse or tab keyboard key to wake.
        /// </summary>
        /// <param name="args">Not used</param>
        /// <note>The program immediately exits.</note>
        static void Main(string[] args)
        {
            SendMessage(HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_POWER_OFF);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);
    }
}
