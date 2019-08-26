using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ISTC.ThirdStage.Advance.AsyncAwait.AA_03
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

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync("https://istc.am/");
            await Task.Delay(5000);
            string urlContents = await getStringTask;
            ContentBox.Text = urlContents;
        }


        //private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        //{
        //    HttpClient client = new HttpClient();
        //    Task<string> getStringTask = client.GetStringAsync("https://istc.am/");
        //    Task.Delay(5000).GetAwaiter().GetResult();
        //    string urlContents = getStringTask.Result;
        //    ContentBox.Text = urlContents;
        //}
    }
}
