using C9VLNK_HFT_2021221.Data;
using C9VLNK_HFT_2021221.Models;
using C9VLNK_HFT_2021221.Repository.Interfaces;
using System;
using System.Linq;

namespace C9VLNK_HFT_2021221.Repository.Repositories
{
    public class SongRepository : Repository<Song>, ISongRepository
    {
        public SongRepository(MusicContext ctx) : base(ctx)
        {

        }
        public override Song GetOne(int id)
        {
            return GetAll().SingleOrDefault(x => x.SongId == id);
        }
        public void AddSong(Song song)
        {
            ctx.Add(song);
            ctx.SaveChanges();
        }
        public void DeleteSong(int songId)
        {
            ctx.Remove(GetOne(songId));
            ctx.SaveChanges();
        }
        public Song GetSong(int songId)
        {
            return GetOne(songId);
        }
        public void UpdateSongLength(int songId, TimeSpan newLength)
        {
            var song = GetOne(songId);
            song.Length = newLength;
            ctx.SaveChanges();
        }
        public void UpdateSongPlays(int songId, int newPlays)
        {

            var song = GetOne(songId);
            song.Plays = newPlays;
            ctx.SaveChanges();
        }
        public void UpdateSongProducer(int songId, string newProducer)
        {
            var song = GetOne(songId);
            song.Producer = newProducer;
            ctx.SaveChanges();
        }
        public void UpdateSongReleaseDate(int songId, DateTime newReleaseDate)
        {
            var song = GetOne(songId);
            song.ReleaseDate = newReleaseDate;
            ctx.SaveChanges();
        }
        public void UpdateSongTitle(int songId, string newTitle)
        {
            var song = GetOne(songId);
            song.Title = newTitle;
            ctx.SaveChanges();
        }
        public void UpdateFullSong(Song song)
        {
            var toUpdateSong = GetOne(song.SongId);

            toUpdateSong.Title = song.Title;
            toUpdateSong.Length = song.Length;
            toUpdateSong.Plays = song.Plays;
            toUpdateSong.ReleaseDate = song.ReleaseDate;
            toUpdateSong.Producer = song.Producer;
            ctx.SaveChanges();
        }
        public int GetSongPlays(Song song)
        {
            return song.Plays;
        }
    }
}
