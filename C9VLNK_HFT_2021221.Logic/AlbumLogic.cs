using C9VLNK_HFT_2021221.Models;
using C9VLNK_HFT_2021221.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace C9VLNK_HFT_2021221.Logic
{
    public interface IAlbumLogic
    {
        void AddAlbum(Album album);

        Album GetAlbum(int albumId);
        int? GetAlbumPlays(int albumId);
        IEnumerable<Album> ReadAllAlbums();

        void UpdateAlbumTitle(int albumId, string newTitle);

        void UpdateAlbumReleaseDate(int albumId, DateTime newReleaseDate);

        void UpdateFullAlbum(Album album);

        void DeleteAlbum(int albumId);

        Album AlbumWithTheMostPlays();
        IEnumerable<AlbumByPlays> AlbumsOrderedByPlays();

        IEnumerable<Album> AlbumsOrderedByReleaseDate();
    }
    public class AlbumLogic : IAlbumLogic
    {
        IAlbumRepository albumRepository;
        ISongRepository songRepository;

        public AlbumLogic(IAlbumRepository iAlbumRepository, ISongRepository ISongRepository)
        {
            albumRepository = iAlbumRepository;
            songRepository = ISongRepository;
        }

        public void AddAlbum(Album album)
        {
            if (album.AlbumTitle == null || album == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                albumRepository.AddAlbum(album);
            }
        }
        public IEnumerable<AlbumByPlays> AlbumsOrderedByPlays()
        {
            var albumsByPlays = (from x in albumRepository.GetAll().ToList()
                                 join y in songRepository.GetAll().ToList() on x.AlbumId equals y.AlbumId
                                 group new { x, y } by x into g
                                 select new AlbumByPlays
                                 {
                                     AlbumId = g.Key.AlbumId,
                                     AlbumTitle = g.Key.AlbumTitle,
                                     Plays = g.Sum(x => x.y.Plays)
                                 }).OrderByDescending(x => x.Plays);


            return albumsByPlays;
        }
        public IEnumerable<Album> AlbumsOrderedByReleaseDate()
        {
            var albums = albumRepository.GetAll();
            if (albums == null)
            {
                throw new NullReferenceException("No album found in the Database...");
            }
            else
            {
                var orderedlist = (from x in albums
                                   orderby x.ReleaseDate descending
                                   select x).ToList();
                return orderedlist;
            }
        }
        public Album AlbumWithTheMostPlays()
        {
            var id = AlbumsOrderedByPlays().FirstOrDefault().AlbumId;
            return GetAlbum(id);

        }
        public void DeleteAlbum(int albumId)
        {
            var album = albumRepository.GetAlbum(albumId);
            if (album == null)
            {
                throw new NullReferenceException("No album found with the given ID..");
            }
            else
            {
                albumRepository.DeleteAlbum(albumId);
            }
        }
        public Album GetAlbum(int albumId)
        {
            var album = albumRepository.GetOne(albumId);
            if (album == null)
            {
                throw new NullReferenceException("No album found with the given ID..");
            }
            else
            {
                return album;
            }
        }
        public int? GetAlbumPlays(int albumId)
        {
            var plays = (from x in AlbumsOrderedByPlays()
                         where x.AlbumId == albumId
                         select x.Plays).FirstOrDefault();

            return plays;

        }
        public IEnumerable<Album> ReadAllAlbums()
        {
            var list = albumRepository.GetAll().ToList();
            if (list == null)
            {
                throw new NullReferenceException("No album found in the DataBase..");
            }
            else
            {
                return list;
            }
        }
        public void UpdateAlbumReleaseDate(int albumId, DateTime newReleaseDate)
        {
            var album = albumRepository.GetOne(albumId);
            if (album == null)
            {
                throw new NullReferenceException("No album found in the DataBase..");
            }
            else
            {
                albumRepository.UpdateAlbumReleaseDate(albumId, newReleaseDate);
            }


        }
        public void UpdateAlbumTitle(int albumId, string newTitle)
        {
            var album = albumRepository.GetOne(albumId);
            if (album == null)
            {
                throw new NullReferenceException("No album found in the DataBase..");
            }
            else
            {
                albumRepository.UpdateAlbumTitle(albumId, newTitle);
            }
        }
        public void UpdateFullAlbum(Album album)
        {
            var toBeUpdated = albumRepository.GetOne(album.AlbumId);
            if (toBeUpdated == null)
            {
                throw new NullReferenceException("No album found in the DataBase..");
            }
            else
            {
                albumRepository.UpdateFullAlbum(album);
            }
        }
    }
}
