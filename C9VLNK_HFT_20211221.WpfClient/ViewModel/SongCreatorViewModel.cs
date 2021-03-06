using C9VLNK_HFT_2021221.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9VLNK_HFT_20211221.WpfClient.ViewModel
{
    public class SongCreatorViewModel : ObservableRecipient
    {
        SongViewModel songViewModel;

        public void AddNewlyCreatedSong(Song song)
        {
            songViewModel.AddNewlyCreatedSong(song);
        }
        public SongCreatorViewModel()
        {
            songViewModel = new SongViewModel();
        }

    }
}
