using C9VLNK_HFT_2021221.Models;
using System;

namespace C9VLNK_HFT_2021221.Repository.Interfaces
{
    public interface IAlbumRepository : IRepository<Album>
    {
        //CRUD

        void AddAlbum(Album album);                     //CREATE 

        Album GetAlbum(int albumId);                                 //READ

        //IList<Album> ReadAllAlbums();



        void UpdateAlbumTitle(int albumId, string newTitle);              //UPDATE

        void UpdateAlbumReleaseDate(int albumId, DateTime newReleaseDate);

        void UpdateFullAlbum(Album album);

        void DeleteAlbum(int albumId);                              //DELETE
    }
}
