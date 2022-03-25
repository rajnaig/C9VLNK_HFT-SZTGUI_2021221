using C9VLNK_HFT_2021221.Logic;
using C9VLNK_HFT_2021221.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9VLNK_HFT_20211221.WpfClient.ViewModel
{
    public class ArtistCreatorViewModel : ObservableRecipient
    {
        ArtistViewModel artistViewModel;

        public void Add(Artist artist)
        {
            artistViewModel.AddNewArtist(artist);
        }
        public ArtistCreatorViewModel()
        {
            artistViewModel = new ArtistViewModel();
        }
    }
}
