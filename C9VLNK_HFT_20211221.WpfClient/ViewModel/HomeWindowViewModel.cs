using C9VLNK_HFT_20211221.WpfClient.Services;
using C9VLNK_HFT_2021221.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace C9VLNK_HFT_20211221.WpfClient.ViewModel
{
    public class HomeWindowViewModel : ObservableObject
    {

        RestService rest;
        IArtistEditorService editorService;
        ArtistViewModel artistViewModel;
        
        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }

        public int PlaysInDatabase
        {
            get
            {
                var plays = rest.GetSingle<int>("stat/playsintheDatabase");
                return plays;
                
            }
        }

        public Artist MostListenedArtist
        {
            get
            {
                var artist = rest.GetSingle<Artist>("stat/mostsuccessfulartist");
                return artist;
            }
        }

        public string MostFamousCountryAmongArtists
        {
            get
            {
                var country = rest.GetSingle<string>("artist/mostfamouscountrybyartistscount");
                return country;
            }
        }

        public void OpenGitHubMethod()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/rajnaig",
                UseShellExecute = true
            });
        }
        
        public ICommand OpenGitHub { get; set; }

        public HomeWindowViewModel()
        {

            if (!IsInDesignMode)
            {
                artistViewModel = new ArtistViewModel();
                rest = new RestService("http://localhost:39308/");

                OpenGitHub = new RelayCommand(

                    () => OpenGitHubMethod()
                );

            }

        }
    }
}
