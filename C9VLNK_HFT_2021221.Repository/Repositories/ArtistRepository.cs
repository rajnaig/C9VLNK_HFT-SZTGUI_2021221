using C9VLNK_HFT_2021221.Data;
using C9VLNK_HFT_2021221.Models;
using C9VLNK_HFT_2021221.Repository.Interfaces;
using System.Linq;

namespace C9VLNK_HFT_2021221.Repository.Repositories
{
    public class ArtistRepository : Repository<Artist>, IArtistRepository
    {
        public ArtistRepository(MusicContext ctx) : base(ctx) { }
        public override Artist GetOne(int id)
        {
            return GetAll().SingleOrDefault(x => x.ArtistId == id);
        }
        public void AddArtist(Artist artist)
        {
            ctx.Add(artist);
            ctx.SaveChanges();
        }
        public void DeleteArtist(int artistId)
        {
            ctx.Remove(GetOne(artistId));
            ctx.SaveChanges();
        }
        public Artist GetArtist(int artistId)
        {
            return GetOne(artistId);
        }
        public void UpdateArtistName(int artistId, string newName)
        {
            var artist = GetOne(artistId);
            artist.Name = newName;
            ctx.SaveChanges();

        }
        public void UpdateArtistNationality(int artistId, Countries Nationality)
        {
            var artist = GetOne(artistId);
            artist.Country = Nationality;
            ctx.SaveChanges();
        }
        public void UpdateFullArtist(Artist artist)
        {
            var toUpdateArtist = GetOne(artist.ArtistId);
            toUpdateArtist.Name = artist.Name;
            toUpdateArtist.Country = artist.Country;
            toUpdateArtist.ProfilPicture = artist.ProfilPicture;
            
            ctx.SaveChanges();
        }
    }
}

