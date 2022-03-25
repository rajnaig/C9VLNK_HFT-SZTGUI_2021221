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
    /// Interaction logic for AlbumEditorWindow.xaml
    /// </summary>
    public partial class AlbumEditorWindow : Window
    {
        public Album currentAlbum { get; set; }
        public AlbumEditorWindow(Album album)
        {
            this.currentAlbum = album;
            this.DataContext = new AlbumEditorViewModel();
            (this.DataContext as AlbumEditorViewModel).Setup(album);
            InitializeComponent();
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

        private void SaveAlbum_ButonClick(object sender, RoutedEventArgs e)
        {
            Album newAlbum = new Album();
            newAlbum.AlbumId = currentAlbum.AlbumId;
            newAlbum.AlbumTitle = tb_Title.Text;

            newAlbum.ArtistId = int.Parse(tb_artistId.Text);
            newAlbum.ReleaseDate = DateTime.Parse(tb_albumReleaseDate.Text);
            newAlbum.AlbumCover = img_albumPicture.Source.ToString();

            (this.DataContext as AlbumEditorViewModel).UpdateAlbum(newAlbum);
            this.DialogResult = true;
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
    }
}
