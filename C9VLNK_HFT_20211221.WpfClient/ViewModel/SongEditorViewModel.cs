using C9VLNK_HFT_2021221.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9VLNK_HFT_20211221.WpfClient.ViewModel
{
    public class SongEditorViewModel : ObservableRecipient
    {
        public Song ActualSong { get; set; }

        SongViewModel SongViewModel;

        public void Setup(Song song)
        {
            this.ActualSong = song;
            this.SongViewModel = new SongViewModel();
        }

        public void UpdateSong(Song song)
        {
            SongViewModel.UpdateSong(song);
        }

        public SongEditorViewModel()
        {

        }

    }
}
