using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Interop;
using mveril.WinRT.InitializeWithWindow.Core;

namespace mveril.WinRT.InitializeWithWindow.WPF
{
    /// <summary>
    /// <see langword="static"/> <see langword="class"/> that contain the WPF <see cref="Window"/> extension method
    /// </summary>
    public static class WPFWindowExtension
    {
#if CSWinRT
        /// <summary>
        /// Extension method to initialize WinRT object with this <see cref="Window"/>
        /// </summary>
        /// <param name="window"></param>
        /// <param name="winRTPtr">The <see cref="IntPtr"/> for the WinRT object</param>
        public static void InitializeWinRTChild(this Window window,IntPtr winRTPtr)
        {
            var h = new WindowInteropHelper(window);
            Helper.Initialize(h.Handle, winRTPtr);
        }
#else
        /// <summary>
        /// Extension method to initialize WinRT object with this <see cref="Window"/>
        /// </summary>
        /// <param name="window"></param>
        /// <param name="winRTObj"></param>
        public static void InitializeWinRTChild(this Window window,object winRTObj)
        {
            var h = new WindowInteropHelper(window);
            Helper.Initialize(h.Handle, winRTObj);
        }
#endif
    }
}
