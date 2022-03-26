using C9VLNK_HFT_20211221.WpfClient.Services;
using C9VLNK_HFT_2021221.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace C9VLNK_HFT_20211221.WpfClient.ViewModel
{
    public class SongViewModel : ObservableRecipient
    {

        ISongEditorService songEditorService;
        private Song selectedSong;

        public Song SelectedSong
        {
            get { return selectedSong; }
            set
            {
                if (value != null)
                {
                    selectedSong = new Song()
                    {
                        Album = value.Album,
                        AlbumId = value.AlbumId,
                        Length = value.Length,
                        LengthTicks = value.LengthTicks,
                        Plays = value.Plays,
                        Producer = value.Producer,
                        ReleaseDate = value.ReleaseDate,
                        SongGenre = value.SongGenre,
                        Title = value.Title,
                        SongId = value.SongId,
                        SongCover = value.SongCover,
                        
                    };
                    SetProperty(ref selectedSong, value);
                    ((RelayCommand)DeleteSongCommand).NotifyCanExecuteChanged();
                    ((RelayCommand)EditSongCommand).NotifyCanExecuteChanged();

                }
            }
        }

        public void UpdateSong(Song song)
        {
            Songs.Update(song);
        }


        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }

        public SongViewModel() :this(IsInDesignMode ? null :Ioc.Default.GetService<ISongEditorService>())
        {

        }
        public ICommand DeleteSongCommand { get; set; }
        public ICommand EditSongCommand { get; set; }
        public RestCollection<Song> Songs { get; set; }

        public SongViewModel(ISongEditorService songEditorService)
        {
            if (!IsInDesignMode)
            {
                Songs = new RestCollection<Song>("http://localhost:39308/", "song");
                this.songEditorService = songEditorService;
                DeleteSongCommand = new RelayCommand(() =>
                {
                    Songs.Delete(SelectedSong.AlbumId);
                },
                () =>
                {
                    return SelectedSong != null;
                });

                EditSongCommand = new RelayCommand(
                    () => songEditorService.EditSong(SelectedSong),
                    () => SelectedSong != null
                );

                SelectedSong = new Song();
            }
        }
    }
}
