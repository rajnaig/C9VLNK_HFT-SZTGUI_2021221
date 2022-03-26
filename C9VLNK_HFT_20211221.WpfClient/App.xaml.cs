using C9VLNK_HFT_20211221.WpfClient.Services;
using C9VLNK_HFT_2021221.Logic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;
using System.Windows;

namespace C9VLNK_HFT_20211221.WpfClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Ioc.Default.ConfigureServices(
                new ServiceCollection()
                    .AddSingleton<IArtistLogic,ArtistLogic>()
                    .AddSingleton<IAlbumLogic,AlbumLogic>()
                    .AddSingleton<ISongLogic,SongLogic>()
                    .AddSingleton<IArtistEditorService,ArtistEditorViaWindow>()
                    .AddSingleton<IArtistCreatorService,ArtistCreatorViaWindow>()
                    .AddSingleton<IAlbumEditorService, AlbumEditorViaWindow>()
                    .AddSingleton<IAlbumCreatorService, AlbumCreatorViaWindow>()
                    .AddSingleton<ISongEditorService, SongEditorViaWindow>()
                    .AddSingleton<ISongCreatorService, SongCreatorViaWindow>()
                    .AddSingleton<IMessenger>(WeakReferenceMessenger.Default)
                    .BuildServiceProvider()
                );
        }

    }
}
