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
        /// <summary>
        /// Extension method to initialize WinRT object with this <see cref="Form"/>
        /// </summary>
        /// <param name="form">The form</param>
        /// <param name="winRTObj">The WinRT object to initialize</param>
        public static void InitializeWinRTChild(this Form form,object winRTObj)
        {
            Helper.Initialize(form.Handle, winRTObj);
        }
    }
}
