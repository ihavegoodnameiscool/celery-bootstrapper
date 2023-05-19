using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CeleryBootstrapper
{
    /// <summary>
    /// Interaction logic for outdated.xaml
    /// </summary>
    public partial class outdated : Window
    {
        public outdated()
        {
            InitializeComponent();
            
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string downloadedversion = File.ReadAllText("celery\\appversion.txt");
            string url = "https://raw.githubusercontent.com/TheSeaweedMonster/Celery/main/version.txt";

            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(url);
            current_version.Content = response;
            installed_version.Content = downloadedversion;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); //close app
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) //allows u to drag it
                this.DragMove();
        }
    }
}
