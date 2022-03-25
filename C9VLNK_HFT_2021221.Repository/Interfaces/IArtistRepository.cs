using C9VLNK_HFT_2021221.Models;

namespace C9VLNK_HFT_2021221.Repository.Interfaces
{
    public interface IArtistRepository : IRepository<Artist>
    {
        //CRUD
        void AddArtist(Artist artist);                     //CREATE 
        Artist GetArtist(int artistId);
        void UpdateArtistName(int artistId, string newName);              //UPDATE
        void UpdateArtistNationality(int artistId, Countries newCountry);
        void UpdateFullArtist(Artist artist);
        void DeleteArtist(int artistId);                   //DELETE

    }
}
