using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Net.Http;

namespace CeleryBootstrapper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            installgrid.Visibility = Visibility.Collapsed;
            updategrid.Visibility = Visibility.Collapsed;
            deletegrid.Visibility = Visibility.Collapsed;


        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation thicknessAnimation = new ThicknessAnimation();
            hello.Visibility = Visibility.Visible;
     
            thicknessAnimation.Duration = TimeSpan.FromSeconds(0.5);
            thicknessAnimation.From = new Thickness(-153, 27, 0, 0);
            thicknessAnimation.To = new Thickness(22, 34, 0, 0);
            hello.BeginAnimation(Grid.MarginProperty, thicknessAnimation);
            welcome.Visibility = Visibility.Visible;
            await Task.Delay(150);
     
            thicknessAnimation.Duration = TimeSpan.FromSeconds(0.5);
            thicknessAnimation.From = new Thickness(508, 27, 0, 0);
            thicknessAnimation.To = new Thickness(218, 27, 0, 0);
            welcome.BeginAnimation(Grid.MarginProperty, thicknessAnimation);
            await Task.Delay(150);

     

            thicknessAnimation.Duration = TimeSpan.FromSeconds(0.5);
            thicknessAnimation.From = new Thickness(499, 76, 0, 0);
            thicknessAnimation.To = new Thickness(246, 60, 0, 0);
           celery.BeginAnimation(Grid.MarginProperty, thicknessAnimation);
            await Task.Delay(150);
            installgrid.Visibility = Visibility.Visible;
            updategrid.Visibility = Visibility.Visible;
            deletegrid.Visibility = Visibility.Visible;

            if (Directory.Exists("celery"))
            {
               
                string downloadedversion = File.ReadAllText("celery\\appversion.txt");
                string url = "https://raw.githubusercontent.com/TheSeaweedMonster/Celery/main/version.txt";

                HttpClient client = new HttpClient();
                string response = await client.GetStringAsync(url);
                if (NormalizeText(response) != NormalizeText(downloadedversion))
                {
                    outdated updatepls = new outdated();
                    updatepls.ShowDialog();
                }
            }

        }

        static string NormalizeText(string text)
        {
            return text.Trim(); // somehow fixes my shitty code
        }


        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) //right click + dragmove moment
                this.DragMove();
        }

        private void installgrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Directory.Exists("celery")) 
            {
                MessageBox.Show("Celery is already installed, please click update instead.");
            }
            if(!Directory.Exists("celery")) 
            {
                Downloading.Content = "                          Downloading Celery.zip...";
                WebClient wc = new WebClient();
                installgrid.Visibility = Visibility.Collapsed;
                updategrid.Visibility = Visibility.Collapsed;
                deletegrid.Visibility = Visibility.Collapsed;
                Downloading.Visibility = Visibility.Visible;
                string URL = "https://cdn.sussy.dev/celery/release.zip"; 
                wc.DownloadFileAsync(new Uri(URL), "Celery.zip");
                wc.DownloadFileCompleted += DownloadCompleted;
                wc.Dispose();
            }
          
        }

        private async void DownloadCompleted(object sender, AsyncCompletedEventArgs e) 
        {
            await Task.Delay(200);
            Downloading.Content = "                                  Extracting celery..";
            ZipFile.ExtractToDirectory("Celery.zip", "celery");
            await Task.Delay(200);
            File.Delete("celery.zip");
            await Task.Delay(200);
            Downloading.Content = "                Done! Find celery in the celery folder";
            await Task.Delay(1000);
            installgrid.Visibility = Visibility.Visible;
            updategrid.Visibility= Visibility.Visible;
            deletegrid.Visibility= Visibility.Visible;
            Downloading.Visibility = Visibility.Collapsed;
            
       
           

        }

        private void deletegrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(Directory.Exists("celery"))
            {
                Directory.Delete("celery", true); //no please dont delete dclcerey!!
                MessageBox.Show("Successfully deleted celery"); 
               
            }
           
        }

        private void updategrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WebClient wc = new WebClient(); 
            if (Directory.Exists("celery")) 
            {

                Directory.Delete("celery", true); //eeasier than other shit
                Downloading.Content = "                          Downloading Celery.zip...";
                Downloading.Visibility = Visibility.Visible;
                installgrid.Visibility = Visibility.Collapsed;
                updategrid.Visibility = Visibility.Collapsed;
                deletegrid.Visibility = Visibility.Collapsed;
                string URL = "https://cdn.sussy.dev/celery/release.zip";
                wc.DownloadFileAsync(new Uri(URL), "Celery.zip");
                wc.DownloadFileCompleted += DownloadCompleted;
                wc.Dispose();
            }
          
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation thicknessAnimation = new ThicknessAnimation();
            thicknessAnimation.Duration = TimeSpan.FromSeconds(0.5); //shitty animations but c#
            thicknessAnimation.To = new Thickness(-153, 27, 0, 0);
            thicknessAnimation.From = new Thickness(22, 34, 0, 0);
            hello.BeginAnimation(Grid.MarginProperty, thicknessAnimation);
            welcome.Visibility = Visibility.Visible;
            await Task.Delay(150);

            thicknessAnimation.Duration = TimeSpan.FromSeconds(0.5);
            thicknessAnimation.To = new Thickness(508, 27, 0, 0);
            thicknessAnimation.From = new Thickness(218, 27, 0, 0);
            welcome.BeginAnimation(Grid.MarginProperty, thicknessAnimation);
            await Task.Delay(150);



            thicknessAnimation.Duration = TimeSpan.FromSeconds(0.5);
            thicknessAnimation.To = new Thickness(499, 76, 0, 0);
            thicknessAnimation.From = new Thickness(246, 60, 0, 0);
            celery.BeginAnimation(Grid.MarginProperty, thicknessAnimation);
            installgrid.Visibility = Visibility.Collapsed;
            updategrid.Visibility = Visibility.Collapsed;
            deletegrid.Visibility = Visibility.Collapsed;
            await Task.Delay(550);
            App.Current.Shutdown();
        }

        

        
    }
}
