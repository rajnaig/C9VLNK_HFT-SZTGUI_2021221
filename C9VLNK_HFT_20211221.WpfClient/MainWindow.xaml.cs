using C9VLNK_HFT_20211221.WpfClient.Services;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace C9VLNK_HFT_20211221.WpfClient
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

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void Button_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Button_Minus(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
