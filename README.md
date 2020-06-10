# WinRTInitializeWithWindow
A C# wrapper around  [IInitializeWithWindow](https://docs.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iinitializewithwindow) with extension method for WPF and Windows Forms
## Example (For WPF and Windows Forms)
```csharp
var dlg = new MessageDialog("Hellow World",$"UWP {nameof(MessageDialog)}") ;
this.InitializeWinRTChild(dlg);
await dlg.ShowAsync();
```
Where `this` is a WPF `Window` or a Windows Forms `form`
## API structure
### WinRTInitializeWithWindow.Core
It's the core of the API whose other components depend.
### WinRTInitializeWithWindow.WinForms
It's the WindowsForms component with the extension for the `form`class.
### WinRTInitializeWithWindow.WPF
It's the WPF component with the extension for the `Window`class.
