using System;
using System.Windows;
using Windows.UI.Popups;
using mveril.WinRT.InitializeWithWindow.WPF;
namespace mveril.WinRT.InitializeWithWindow.samples.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new MessageDialog("Hellow World",$"UWP {nameof(MessageDialog)}") ;
            this.InitializeWinRTChild(dlg);
            await dlg.ShowAsync();
        }
    }
}
