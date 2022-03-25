using C9VLNK_HFT_2021221.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9VLNK_HFT_20211221.WpfClient.ViewModel
{
    public class AlbumEditorViewModel : ObservableRecipient
    {
        public Album ActualAlbum { get; set; }  
        AlbumViewModel albumViewModel { get; set; }
        public void Setup(Album album)
        {
            this.albumViewModel = new AlbumViewModel();
            this.ActualAlbum = album;
        }
        public void UpdateAlbum(Album album)
        {
            albumViewModel.UpdateAlbum(album);
        }

        public AlbumEditorViewModel()
        {

        }
    }
}
