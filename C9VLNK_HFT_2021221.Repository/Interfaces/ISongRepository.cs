using C9VLNK_HFT_2021221.Models;
using System;

namespace C9VLNK_HFT_2021221.Repository.Interfaces
{
    public interface ISongRepository : IRepository<Song>
    {
        //CRUD
        void AddSong(Song song);                     //CREATE 
        Song GetSong(int songId);                                 //READ
        int GetSongPlays(Song song);
        void UpdateSongTitle(int songId, string newTitle);              //UPDATE
        void UpdateSongLength(int songId, TimeSpan newLength);
        void UpdateSongPlays(int songId, int newPlays);
        void UpdateFullSong(Song song);
        void UpdateSongReleaseDate(int songId, DateTime newReleaseDate);
        void UpdateSongProducer(int songId, string newProducer);
        void DeleteSong(int songId);                              //DELETE
    }
}
