using C9VLNK_HFT_20211221.WpfClient.Windows;
using C9VLNK_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9VLNK_HFT_20211221.WpfClient.Services
{
    public class ArtistCreatorViaWindow : IArtistCreatorService
    {
        public Artist GiveBackArtist()
        {
            ArtistCreatorWindow artistCreatorWindow = new ArtistCreatorWindow();
            Artist newArtist = new Artist();
            newArtist = (Artist)artistCreatorWindow.DataContext;
            return newArtist;
        }

        public void RegisterArtist()
        {
            new ArtistCreatorWindow().ShowDialog();
        }


    }
}
