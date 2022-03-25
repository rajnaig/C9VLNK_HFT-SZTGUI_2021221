using C9VLNK_HFT_20211221.WpfClient.Services;
using C9VLNK_HFT_2021221.Logic;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.ComponentModel;
using System.Windows;


namespace C9VLNK_HFT_20211221.WpfClient.ViewModel
{
    public class MainWindowViewModel : ObservableRecipient
    {
        public RelayCommand NonCrudViewCommand { get; set; }
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand ArtisViewCommand { get; set; }
        public RelayCommand AlbumViewCommand { get; set; }
        public RelayCommand SongViewCommand { get; set; }



        public NonCrudFiltersViewModel NonCrudVM { get; set; }
        public HomeWindowViewModel HomeVm { get; set; }
        public ArtistViewModel ArtisVM { get; set; }
        public AlbumViewModel AlbumVM { get; set; }
        public SongViewModel SongVM { get; set; }

        DateTime currentTime;

        private object currentView;

        public object CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                OnPropertyChanged();
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

        public string Greetings
        {
            get
            {
                if (currentTime.Hour < 6)
                {
                    return "Good Night!";
                }
                else if(currentTime.Hour < 10 )
                {
                    return "Good Morning!";
                }
                else if (currentTime.Hour < 18)
                {
                    return "Good Afternoon!";
                }

                else if (currentTime.Hour < 22)
                {
                    return "Good Evening!";
                }
                else 
                {
                    return "Good Night!";
                }
            }

        }
       

        public MainWindowViewModel()
        {
            if (!IsInDesignMode)
            {

                currentTime = DateTime.Now.ToLocalTime();
                
                HomeVm = new HomeWindowViewModel();
                ArtisVM = new ArtistViewModel();
                AlbumVM = new AlbumViewModel();
                SongVM = new SongViewModel();
                NonCrudVM = new NonCrudFiltersViewModel();

                CurrentView = HomeVm;

                HomeViewCommand = new RelayCommand(() =>
                {
                    CurrentView = HomeVm;
                });

                ArtisViewCommand = new RelayCommand(() =>
                {
                    CurrentView = ArtisVM;
                });


                AlbumViewCommand = new RelayCommand(() =>
                {
                    CurrentView = AlbumVM;
                });

                SongViewCommand = new RelayCommand(() =>
                {
                    CurrentView = SongVM;
                });

                NonCrudViewCommand = new RelayCommand(() =>
                {
                    CurrentView = NonCrudVM;
                });
            }
        }
    }
}
