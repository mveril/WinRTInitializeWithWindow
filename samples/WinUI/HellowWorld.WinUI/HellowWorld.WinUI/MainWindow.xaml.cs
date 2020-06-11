using System;
using Microsoft.UI.Xaml;
using mveril.WinRT.InitializeWithWindow.WPF;
using Windows.UI.Popups;

// The Blank Window item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HellowWorld.WinUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new MessageDialog("Hellow World", $"UWP {nameof(MessageDialog)}");
            this.InitializeWinRTChild(dlg.ThisPtr);
            await dlg.ShowAsync();
        }
    }
}
