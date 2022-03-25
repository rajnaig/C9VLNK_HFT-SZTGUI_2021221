using C9VLNK_HFT_2021221.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9VLNK_HFT_20211221.WpfClient.ViewModel
{
    public class AlbumCreatorViewModel : ObservableRecipient
    {
        AlbumViewModel albumViewModel;

        public AlbumCreatorViewModel()
        {
            this.albumViewModel = new AlbumViewModel();
        }

        public void AddNewlyCreatedAlbum(Album album)
        {
            albumViewModel.AddNewlyCreatedAlbum(album);
        }
    }
}
