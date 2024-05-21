using System;
using System.Text;
using System.Runtime.InteropServices;
using SendKeys.BLL.ActiveWindow;
using SendKeys.Common;
using HWND = System.IntPtr;
using System.Collections.Generic;

namespace SendKeys.BLL
{
    public static class WindowAPI
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public static void SetActiveWindow(IntPtr windowHandle) => SetForegroundWindow(windowHandle);

        public static Option<ActiveWindowModel> GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
                return Option<ActiveWindowModel>.Some(ActiveWindowModel.Create(handle, Buff.ToString()));

            return Option<ActiveWindowModel>.None();
        }

        public static void SendKeys(IntPtr windowHandle, string key)
        {
            if (SetForegroundWindow(windowHandle))
                System.Windows.Forms.SendKeys.Send(key);
        }

        public static void SendKeys(IntPtr windowHandle, bool ctrlActive, bool altActive, string key)
        {
            if (ctrlActive)
                SendKeys(windowHandle, "^{" + key.ToLower() + "}");
            else if (altActive)
                SendKeys(windowHandle, "%{" + key.ToLower() + "}");
            else
                SendKeys(windowHandle, "{" + key + "}");
        }

        // https://stackoverflow.com/questions/7268302/get-the-titles-of-all-open-windows
        /// <summary>Returns a dictionary that contains the handle and title of all the open windows.</summary>
        /// <returns>A dictionary that contains the handle and title of all the open windows.</returns>
        public static IDictionary<HWND, string> GetOpenWindows()
        {
            HWND shellWindow = GetShellWindow();
            Dictionary<HWND, string> windows = new Dictionary<HWND, string>();

            EnumWindows(delegate (HWND hWnd, int lParam)
            {
                if (hWnd == shellWindow) return true;
                if (!IsWindowVisible(hWnd)) return true;

                int length = GetWindowTextLength(hWnd);
                if (length == 0) return true;

                StringBuilder builder = new StringBuilder(length);
                GetWindowText(hWnd, builder, length + 1);

                windows[hWnd] = builder.ToString();
                return true;

            }, 0);

            return windows;
        }

        private delegate bool EnumWindowsProc(HWND hWnd, int lParam);

        [DllImport("USER32.DLL")]
        private static extern bool EnumWindows(EnumWindowsProc enumFunc, int lParam);

        [DllImport("USER32.DLL")]
        private static extern int GetWindowTextLength(HWND hWnd);

        [DllImport("USER32.DLL")]
        private static extern bool IsWindowVisible(HWND hWnd);

        [DllImport("USER32.DLL")]
        private static extern IntPtr GetShellWindow();
    }
}
