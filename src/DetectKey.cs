using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Eze.IO.Workspace
{
    /// <summary>
    /// Class for detecting keyboard key presses
    /// </summary>
    /// <exception cref="ObjectNotFoundException">Exception thrown when <see cref="Loggedkey"/> has a null or invalid object on OnKeyPressed event</exception>
    /// <exception cref="InvalidOperationException">Exception thrown when virtual key cannot be obtained</exception>
    /// <exception cref="AccessViolationException">Exception thrown when key information is not accessible</exception>
    public static class DetectKey
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                try
                {
                    int vkCode = Marshal.ReadInt32(lParam);
                    var keyName = Enum.GetName(typeof(VirtualKeys), vkCode);
                    var text = ((VirtualKeys)vkCode).ToString();
                    var vKey = (VirtualKeys)Enum.Parse(typeof(VirtualKeys), text);

                    using (LoggedKeys logs = new LoggedKeys())
                    {
                        logs.Key = vKey;
                        logs.KeyName = keyName;

                        if (vKey.GetType() != typeof(VirtualKeys))
                            return CallNextHookEx(_hookID, nCode, wParam, lParam);

                        KeyEvent?.Invoke(logs);
                    }
                }
                catch (Exception er)
                {
                    if (er is ArgumentNullException || er is ArgumentException)
                    {
                        throw new ObjectNotFoundException("Failed to get key name and key type!");
                    }
                    else if (er is AccessViolationException)
                    {
                        throw new AccessViolationException("Error occured while obtaining key information!", er.InnerException);
                    }
                    else if (er is OverflowException)
                    {
                        throw new InvalidOperationException("Failed to convert keys to a virtual key type", er.InnerException);
                    }
                    else
                    {
                        throw new InvalidOperationException(er.Message, er.InnerException);
                    }
                }
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private static readonly object _lock = new Object();
        private static event KeyPressedHandler KeyEvent;

        /// <summary>
        /// Return true if key presses are being detected
        /// </summary>
        public static Boolean IsDetecting
        {
            get
            {
                if (_hookID != IntPtr.Zero)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// Event triggered when keyboard key is pressed
        /// </summary>
        public static event KeyPressedHandler OnKeyPressed
        {
            add
            {
                lock (_lock)
                {
                    _hookID = SetHook(_proc);
                    KeyEvent += value;
                }
            }
            remove
            {
                lock (_lock)
                {
                    UnhookWindowsHookEx(_hookID);
                    _hookID = IntPtr.Zero;
                    KeyEvent -= value;
                }
            }
        }
    }
}
