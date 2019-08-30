using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ISTC.Event.WPF
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

        private async void Lutvik(object sender, EventArgs e)
        {
            Text.Text = "Hello";
            MessageBox.Show("Hi all");
            await Task.Delay(1);
        }

        private async void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount < 2)
            {
                MessageBox.Show("1");
            }
            else MessageBox.Show("MouseDoubleClick");
            await Task.Delay(1);
        }
    }
}
