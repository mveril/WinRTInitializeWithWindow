using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using mveril.WinRT.InitializeWithWindow.Core;

namespace mveril.WinRT.InitializeWithWindow.WinForms
{
    /// <summary>
    /// <see langword="static"/> <see langword="class"/> that contain the Windows Form <see cref="Form"/> extension method
    /// </summary>
    public static class WinFormsWindowExtension
    {
#if CSWinRT
        /// <summary>
        /// Extension method to initialize WinRT object with this <see cref="Form"/>
        /// </summary>
        /// <param name="form">The form</param>
        /// <param name="winRTPtr">The <see cref="IntPtr"/> for the WinRT object</param>
        public static void InitializeWinRTChild(this Form form,IntPtr winRTPtr)
        {
            Helper.Initialize(form.Handle, winRTPtr);
        }
#else
        /// <summary>
        /// Extension method to initialize WinRT object with this <see cref="Form"/>
        /// </summary>
        /// <param name="form">The form</param>
        /// <param name="winRTObj">The WinRT object to initialize</param>
        public static void InitializeWinRTChild(this Form form,object winRTObj)
        {
            Helper.Initialize(form.Handle, winRTObj);
        }
#endif
    }
}
