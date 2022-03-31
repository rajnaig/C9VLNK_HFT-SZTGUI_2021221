using C9VLNK_HFT_20211221.WpfClient.ViewModel;
using C9VLNK_HFT_2021221.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace C9VLNK_HFT_20211221.WpfClient.Windows
{
    /// <summary>
    /// Interaction logic for ArtistCreatorWindow.xaml
    /// </summary>
    public partial class ArtistCreatorWindow : Window
    {
        public ArtistCreatorWindow()
        {
            InitializeComponent();
            this.DataContext = new ArtistCreatorViewModel();
        }

        private void SaveArtist_ButonClick(object sender, RoutedEventArgs e)
        {
            var answer = MessageBox.Show("Are you finnished with the new artist? ", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.Yes)
            {
                Artist newArtist = new Artist();

                newArtist.Name = tb_artistName.Text;
                newArtist.ArtistGenre = (Genres)Enum.Parse(typeof(Genres), cb_artistGenre.Text);
                newArtist.Country = (Countries)Enum.Parse(typeof(Countries), cb_artistCountry.Text);
                newArtist.ProfilPicture = img_artisPicture.Source.ToString();

                (this.DataContext as ArtistCreatorViewModel).Add(newArtist);
                this.DialogResult = true;
            } 
        }

        private void btn_BrowseNewPictureFromDevice(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;)|*.BMP;*.JPG;|All files (*.*)|*.*";
            ofd.ShowDialog();
            var file = ofd.FileName;
            lb_ArtistPicPath.Content = file;

            if (!file.Equals(""))
            {
                img_artisPicture.Source = new ImageSourceConverter().ConvertFromString(file) as ImageSource;
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void Button_Minus(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Close(object sender, RoutedEventArgs e)
        {
            var answer = MessageBox.Show("Are you sure that you want to close this window?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
