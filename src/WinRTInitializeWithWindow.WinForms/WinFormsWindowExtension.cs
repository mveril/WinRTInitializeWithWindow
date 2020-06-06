using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using mveril.WinRT.InitializeWithWindow.Core;

namespace mveril.WinRT.InitializeWithWindow.WinForms
{
#pragma warning disable CS1591
    public static class WinFormsWindowExtension
#pragma warning restore CS1591
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
