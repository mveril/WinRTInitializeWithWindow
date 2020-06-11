using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.UI.Xaml;
using mveril.WinRT.InitializeWithWindow.Core;
using mveril.WinRT.InitializeWithWindow.WinUI.CSWinRT;

namespace mveril.WinRT.InitializeWithWindow.WPF
{
#pragma warning disable CS1591
    public static class WinUIWindowExtension
#pragma warning restore CS1591
    {
        /// <summary>
        /// Extension method to initialize WinRT object with this <see cref="Window"/>
        /// </summary>
        /// <param name="window"></param>
        /// <param name="winRTPtr">The <see cref="IntPtr"/> for the WinRT object</param>
        public static void InitializeWinRTChild(this Window window,IntPtr winRTPtr)
        {
            WindowWrapper ww = WindowWrapper.FromAbi(window.ThisPtr);
            Helper.Initialize(ww.WindowHandle, winRTPtr);
        }
    }
}
