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
    /// Interaction logic for AlbumCreatorWindow.xaml
    /// </summary>
    public partial class AlbumCreatorWindow : Window
    {
        public AlbumCreatorWindow()
        {
            InitializeComponent();
            this.DataContext = new AlbumCreatorViewModel();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void btn_BrowseNewPictureFromDevice(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;)|*.BMP;*.JPG;|All files (*.*)|*.*";
            ofd.ShowDialog();
            var file = ofd.FileName;
            lb_AlbumPicPath.Content = file;

            if (!file.Equals(""))
            {
                img_albumPicture.Source = new ImageSourceConverter().ConvertFromString(file) as ImageSource;
            }
        }

        private void Button_Close(object sender, RoutedEventArgs e)
        {
            var answer = MessageBox.Show("Are you sure that you want to close this window?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void Button_Minus(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void SaveAlbum_ButonClick(object sender, RoutedEventArgs e)
        {
            var answer = MessageBox.Show("Are you finnished with the new abum?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.Yes)
            {
                Album newAlbum = new Album();

                newAlbum.AlbumTitle = tb_Title.Text;
                newAlbum.ArtistId = int.Parse(tb_artistId.Text);
                newAlbum.ReleaseDate = DateTime.Parse(tb_albumReleaseDate.Text);
                newAlbum.AlbumCover = img_albumPicture.Source.ToString();

                (this.DataContext as AlbumCreatorViewModel).AddNewlyCreatedAlbum(newAlbum);
                this.DialogResult = true;
            }
        }

    }

}
