using C9VLNK_HFT_2021221.Data;
using C9VLNK_HFT_2021221.Models;
using C9VLNK_HFT_2021221.Repository.Interfaces;
using System;
using System.Linq;

namespace C9VLNK_HFT_2021221.Repository.Repositories
{
    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(MusicContext ctx) : base(ctx) { }
        public override Album GetOne(int id)
        {
            return GetAll().SingleOrDefault(x => x.AlbumId == id);
        }
        public void AddAlbum(Album album)
        {
            ctx.Add(album);
            ctx.SaveChanges();
        }
        public void DeleteAlbum(int albumId)
        {
            ctx.Remove(GetOne(albumId));
            ctx.SaveChanges();
        }
        public Album GetAlbum(int albumId)
        {
            return GetOne(albumId);
        }
        public void UpdateAlbumReleaseDate(int albumId, DateTime newReleaseDate)
        {
            var album = GetOne(albumId);
            album.ReleaseDate = newReleaseDate;
            ctx.SaveChanges();
        }
        public void UpdateAlbumTitle(int albumId, string newTitle)
        {
            var album = GetOne(albumId);
            album.AlbumTitle = newTitle;
            ctx.SaveChanges();
        }
        public void UpdateFullAlbum(Album album)
        {
            var toUpdateAlbum = GetOne(album.AlbumId);

            toUpdateAlbum.AlbumTitle = album.AlbumTitle;
            toUpdateAlbum.ReleaseDate = album.ReleaseDate;
            toUpdateAlbum.ArtistId = album.ArtistId;
            toUpdateAlbum.AlbumCover =album.AlbumCover;
 
            ctx.SaveChanges();

        }
    }
}
