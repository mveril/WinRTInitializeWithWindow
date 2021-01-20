using System;
using System.Windows.Forms;
using Windows.UI.Popups;
using mveril.WinRT.InitializeWithWindow.WinForms;

namespace mveril.WinRT.InitializeWithWindow.samples.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var dlg = new MessageDialog("Hellow World", $"UWP {nameof(MessageDialog)}");
            this.InitializeWinRTChild(dlg);
            await dlg.ShowAsync();
        }
    }
}
