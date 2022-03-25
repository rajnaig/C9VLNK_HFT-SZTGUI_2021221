using C9VLNK_HFT_20211221.WpfClient.Services;
using C9VLNK_HFT_2021221.Logic;
using C9VLNK_HFT_2021221.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace C9VLNK_HFT_20211221.WpfClient.ViewModel
{
    public class ArtistViewModel : ObservableObject
    {
        IArtistEditorService editorService;
        IArtistCreatorService creatorService;
        IMessenger messenger;
        static Random random;


        private string artistProfilPicture;

        public string ArtistProfilPicture
        {
            get
            {
                return artistProfilPicture;
            }
            set
            {
                SetProperty(ref artistProfilPicture, value);
            }
        }


        private RestCollection<Artist> artists;

        public RestCollection<Artist> Artists
        {
            get { return artists; }
            set
            {
                SetProperty(ref artists, value);
            }
        }

        private Artist selectedArtist;
        public Artist SelectedArtist
        {
            get
            {
                return selectedArtist;
            }
            set
            {
                if (value != null)
                {
                    selectedArtist = new Artist()
                    {
                        Name = value.Name,
                        Albums = value.Albums,
                        ArtistGenre = value.ArtistGenre,
                        ArtistId = value.ArtistId,
                        Country = value.Country,
                        ProfilPicture = value.ProfilPicture
                    };
                    SetProperty(ref selectedArtist, value);
                    ((RelayCommand)DeleteArtistCommand).NotifyCanExecuteChanged();
                    ((RelayCommand)EditArtistCommand).NotifyCanExecuteChanged();
                }
            }

        }

        public ICommand DeleteArtistCommand { get; set; }
        public ICommand EditArtistCommand { get; set; }
        public ICommand ArtistCreatorCommand { get; set; }
        public ICommand ListArtistsByPlaysCommand { get; set; }

        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }

        public ArtistViewModel()
          : this(IsInDesignMode ? null : Ioc.Default.GetService<IArtistEditorService>()
                , IsInDesignMode ? null : Ioc.Default.GetService<IArtistCreatorService>())
        {

        }

        public void DeleteArtistById(int artistId)
        {
            var answer = MessageBox.Show("Are you sure that you want to remove the choosen artist?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.Yes)
            {
                Artists.Delete(artistId);
                //messenger.Send("Artist removed from database permanently", "ArtistInfo");
            }

        }

        public void UpdateArtist(Artist artist)
        {
            Artists.Update(artist);
        }
        public void AddNewArtist(Artist artist)
        {
            Artists.Add(artist);
        }
        

        public ArtistViewModel(IArtistEditorService editorService, IArtistCreatorService artistCreatorService)
        {
            if (!IsInDesignMode)
            {
                Artists = new RestCollection<Artist>("http://localhost:39308/", "artist");

                this.editorService = editorService;
                this.creatorService = artistCreatorService;

                DeleteArtistCommand = new RelayCommand(
                    () => DeleteArtistById(SelectedArtist.ArtistId),
                    () => SelectedArtist != null
                    );

                EditArtistCommand = new RelayCommand(
                    () => editorService.EditArtist(SelectedArtist),
                    () => SelectedArtist != null
                );

                ArtistCreatorCommand = new RelayCommand(
                    () => artistCreatorService.RegisterArtist(),
                    () => SelectedArtist != null
                );
                SelectedArtist = new Artist();
            }
        }
    }
}
