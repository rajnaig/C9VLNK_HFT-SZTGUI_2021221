using C9VLNK_HFT_20211221.WpfClient.ViewModel;
using C9VLNK_HFT_2021221.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace C9VLNK_HFT_20211221.WpfClient
{
    /// <summary>
    /// Interaction logic for ArtistEditorWindow.xaml
    /// </summary>
    public partial class ArtistEditorWindow : Window
    {
        public Artist currentArtist { get; set; }
        
        public ArtistEditorWindow(Artist artist)
        {
            InitializeComponent();
            this.currentArtist = artist;
            
            this.DataContext = new ArtistEditorWindowViewModel();
            (this.DataContext as ArtistEditorWindowViewModel).Setup(artist);
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void SaveArtist_ButonClick(object sender, RoutedEventArgs e)
        {
            foreach (var item in sp_ArtistEditor.Children)
            {
                if (item is TextBox t)
                {
                    t.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                }
                if (item is ComboBox c)
                {
                    c.GetBindingExpression(ComboBox.TextProperty).UpdateSource();
                }

                if (item is Image i)
                {
                    i.GetBindingExpression(Image.SourceProperty).UpdateSource();
                }
            }

            Artist newArtist = new Artist();
            newArtist.ArtistId = currentArtist.ArtistId;
            newArtist.Name = tb_artistName.Text;
            newArtist.ArtistGenre = (Genres)Enum.Parse(typeof(Genres), cb_artistGenre.Text);
            newArtist.Country = (Countries)Enum.Parse(typeof(Countries),cb_artistCountry.Text);

            newArtist.ProfilPicture = img_artisPicture.Source.ToString();
            (this.DataContext as ArtistEditorWindowViewModel).UpdateArtist(newArtist);

            this.DialogResult = true;
            
        }

        private void btn_BrowseNewPictureFromDevice(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() ;
            ofd.Filter = "Image Files(*.BMP;*.JPG;)|*.BMP;*.JPG;|All files (*.*)|*.*";
            ofd.ShowDialog();
            var file = ofd.FileName;
            lb_ArtistPicPath.Content = file;

            if (!file.Equals(""))
            {
                img_artisPicture.Source = new ImageSourceConverter().ConvertFromString(file) as ImageSource;
            }
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
