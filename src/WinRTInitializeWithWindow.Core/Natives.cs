using System;
using System.Runtime.InteropServices;


namespace mveril.WinRT.InitializeWithWindow.Core.Natives
{
    /// <summary>
    /// COM Import of the native <c>IInitializeWithWindow</c> <see langword="interface"></see> <see href="https://devblogs.microsoft.com/oldnewthing/20190412-00/?p=102413">Related blog post</see> or <seealso href="https://docs.microsoft.com/windows/uwp/design/shell/tiles-and-notifications/secondary-tiles-desktop-pinning">this C# example</seealso>
    /// </summary>
    [ComImport]
    [Guid("3E68D4BD-7135-4D10-8018-9FB6D9F33FA1")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IInitializeWithWindow
    {
#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement
        void Initialize(IntPtr hwnd);
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement
    }

}