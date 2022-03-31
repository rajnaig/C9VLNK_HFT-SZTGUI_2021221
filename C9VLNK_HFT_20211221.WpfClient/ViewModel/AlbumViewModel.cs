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
    public class AlbumViewModel : ObservableRecipient
    {
        IAlbumEditorService albumEditorService;
        IAlbumCreatorService albumCreatorService;
        public ICommand DeleteAlbumCommand { get; set; }
        public ICommand CreateNewAlbumCommand { get; set; }
        public ICommand EditAlbumCommand { get; set; }


        private Album selectedAlbum;
        public Album SelectedAlbum
        {
            get { return selectedAlbum; }
            set
            {
                if (value != null)
                {
                    selectedAlbum = new Album()
                    {
                        AlbumId = value.AlbumId,
                        AlbumTitle = value.AlbumTitle,
                        ArtistId = value.ArtistId,
                        Songs = value.Songs,
                        Artist = value.Artist,
                        ReleaseDate = value.ReleaseDate,
                        AlbumCover = value.AlbumCover
                        
                    };
                    SetProperty(ref selectedAlbum, value);
                    (DeleteAlbumCommand as RelayCommand).NotifyCanExecuteChanged();

                }
            }
        }

        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }

        public AlbumViewModel()
         : this(IsInDesignMode ? null : Ioc.Default.GetService<IAlbumEditorService>(),
               (IsInDesignMode ? null : Ioc.Default.GetService<IAlbumCreatorService>()
               ))
        {
        }

        public RestCollection<Album> Albums { get; set; }
       
        public void UpdateAlbum(Album album)
        {
            Albums.Update(album);
        }

        public void AddNewlyCreatedAlbum(Album album)
        {
            Albums.Add(album);
        }
        public void DeleteAlbumById(int id)
        {
            var answer = MessageBox.Show("Are you sure that you want to remove the choosen album?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.Yes)
            {
                Albums.Delete(id);
                //messenger.Send("Artist removed from database permanently", "ArtistInfo");
            }

        }
        public AlbumViewModel(IAlbumEditorService  albumEditorService,
                              IAlbumCreatorService albumCreatorService)
        {
            if (!IsInDesignMode)
            {
                this.albumEditorService = albumEditorService;
                this.albumCreatorService = albumCreatorService;
                Albums = new RestCollection<Album>("http://localhost:39308/", "album","hub");

                DeleteAlbumCommand = new RelayCommand(() =>
                {
                    DeleteAlbumById(SelectedAlbum.AlbumId);
                },
                () =>
                {
                    return SelectedAlbum != null;
                });

                CreateNewAlbumCommand = new RelayCommand(() =>
                {
                    albumCreatorService.CreateAlbum();
                });

                EditAlbumCommand = new RelayCommand(
                    () => albumEditorService.EditAlbum(SelectedAlbum),
                    () => SelectedAlbum != null
                    );

                SelectedAlbum = new Album();
            }
        }
    }

}
