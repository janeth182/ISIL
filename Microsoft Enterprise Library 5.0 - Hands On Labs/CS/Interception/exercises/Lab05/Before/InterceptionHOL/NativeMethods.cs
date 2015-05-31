using System;
using System.Runtime.InteropServices;

namespace InterceptionHOL
{
    /// <summary>
    /// Contains InterOp method calls used by the application.
    /// </summary>
    public static class NativeMethods
    {
        [DllImport("user32.dll")]
        internal static extern
            bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        internal static extern
            bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        internal static extern
            bool IsIconic(IntPtr hWnd);

        internal static int SW_RESTORE = 9;
    }
}
