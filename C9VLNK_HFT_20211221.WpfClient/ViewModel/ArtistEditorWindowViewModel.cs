using C9VLNK_HFT_2021221.Logic;
using C9VLNK_HFT_2021221.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9VLNK_HFT_20211221.WpfClient.ViewModel
{
    public class ArtistEditorWindowViewModel : ObservableRecipient
    {
        public Artist ActualArtist { get; set; }
        ArtistViewModel artistViewModel;

        //ObservableCollection<Album> ActualArtistAlbums
        //{
        //    get
        //    {
        //        foreach (var album in ActualArtist.Albums)
        //        {
        //            ActualArtistAlbums.Add(album);
        //        }
        //        return ActualArtistAlbums;
                
        //    }
        //}
        public void Setup(Artist artist)
        {
            
            this.artistViewModel = new ArtistViewModel();
            this.ActualArtist = artist;
        }
        public void UpdateArtist(Artist artist)
        {
            artistViewModel.UpdateArtist(artist);
        }

        public ArtistEditorWindowViewModel()
        {

        }
    }
}
