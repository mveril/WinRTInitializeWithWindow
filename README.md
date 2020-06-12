# WinRTInitializeWithWindow
A C# wrapper around  [IInitializeWithWindow](https://docs.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iinitializewithwindow) with extension method for WPF and Windows Forms
## Example (for WPF and Windows Forms)
```csharp
var dlg = new MessageDialog("Hellow World",$"UWP {nameof(MessageDialog)}") ;
this.InitializeWinRTChild(dlg);
await dlg.ShowAsync();
```
Where `this` is a WPF `Window` or a Windows Forms `form`
## API structure
### WinRTInitializeWithWindow.Core
[![Nuget WinRTInitializeWithWindow.Core Package](https://img.shields.io/nuget/v/WinRTInitializeWithWindow.Core)](https://www.nuget.org/packages/WinRTInitializeWithWindow.Core/) [![Nuget WinRTInitializeWithWindow.Core Package download counter](https://img.shields.io/nuget/dt/WinRTInitializeWithWindow.Core)](https://www.nuget.org/packages/WinRTInitializeWithWindow.Core/)

It's the core of the API whose other components depend.
### WinRTInitializeWithWindow.WinForms
[![Nuget WinRTInitializeWithWindow.WinForms Package](https://img.shields.io/nuget/v/WinRTInitializeWithWindow.WinForms)](https://www.nuget.org/packages/WinRTInitializeWithWindow.WinForms/) [![Nuget WinRTInitializeWithWindow.WinForms Package download counter](https://img.shields.io/nuget/dt/WinRTInitializeWithWindow.WinForms)](https://www.nuget.org/packages/WinRTInitializeWithWindow.WinForms/)

It's the WindowsForms component with the extension for the `form` class.
### WinRTInitializeWithWindow.WPF
[![Nuget WinRTInitializeWithWindow.WPF Package](https://img.shields.io/nuget/v/WinRTInitializeWithWindow.WPF)](https://www.nuget.org/packages/WinRTInitializeWithWindow.WPF/) [![Nuget WinRTInitializeWithWindow.WPF Package download counter](https://img.shields.io/nuget/dt/WinRTInitializeWithWindow.WPF)](https://www.nuget.org/packages/WinRTInitializeWithWindow.WPF/)

It's the WPF component with the extension for the `Window` class.
