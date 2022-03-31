using C9VLNK_HFT_2021221.Models;
using C9VLNK_HFT_2021221.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace C9VLNK_HFT_2021221.Logic
{
    public interface ISongLogic
    {
        //CRUD
        void AddSong(Song song);
        Song GetSong(int songId);
        int GetSongPlays(int songId);
        IEnumerable<Song> ReadAllSongs();
        IEnumerable<Genres> GetGenres();
        void UpdateSongTitle(int songId, string newTitle);
        void UpdateSongLength(int songId, TimeSpan newLength);
        void UpdateSongPlays(int songId, int newPlays);
        void UpdateFullSong(Song song);
        void UpdateSongReleaseDate(int songId, DateTime newReleaseDate);
        void UpdateSongProducer(int songId, string newProducer);
        void DeleteSong(int songId);


        // NON CRUD
        PlaysByGenres MostPlayedGenre();
        IEnumerable<PlaysByGenres> GenresOrderedByPlays();
        int PlaysInDatabase();
    }
    public class SongLogic : ISongLogic
    {
        ISongRepository songRepository;

        public SongLogic(ISongRepository songRepository)
        {
            this.songRepository = songRepository;
        }

        public void AddSong(Song song)
        {
            if (song.Title == null || song == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                songRepository.AddSong(song);
            }
        }
        public void DeleteSong(int songId)
        {
            var song = songRepository.GetSong(songId);
            if (song == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                songRepository.DeleteSong(songId);
            }
        }
        public Song GetSong(int songId)
        {
            var song = songRepository.GetOne(songId);
            if (song == null)
            {
                throw new NullReferenceException();
            }
            else
            {

                return song;
            }
        }
        public int GetSongPlays(int songId)
        {
            var song = GetSong(songId);
            return song.Plays;
        }
        public IEnumerable<Song> ReadAllSongs()
        {
            var songs = songRepository.GetAll();

            if (songs == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                return songs;
            }
        }
        public void UpdateFullSong(Song song)
        {
            var toUpdateSong = GetSong(song.SongId);
            if (toUpdateSong == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                songRepository.UpdateFullSong(song);
            }
        }
        public void UpdateSongLength(int songId, TimeSpan newLength)
        {
            var song = GetSong(songId);
            if (song == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                songRepository.UpdateSongLength(songId, newLength);
            }
        }
        public void UpdateSongPlays(int songId, int newPlays)
        {
            var song = GetSong(songId);
            if (song == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                songRepository.UpdateSongPlays(songId, newPlays);
            }
        }
        public void UpdateSongProducer(int songId, string newProducer)
        {
            var song = GetSong(songId);
            if (song == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                songRepository.UpdateSongProducer(songId, newProducer);
            }
        }
        public void UpdateSongReleaseDate(int songId, DateTime newReleaseDate)
        {
            var song = GetSong(songId);
            if (song == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                songRepository.UpdateSongReleaseDate(songId, newReleaseDate);
            }
        }
        public void UpdateSongTitle(int songId, string newTitle)
        {
            var song = GetSong(songId);
            if (song == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                songRepository.UpdateSongTitle(songId, newTitle);
            }
        }
        public PlaysByGenres MostPlayedGenre()
        {
            var genre = GenresOrderedByPlays().FirstOrDefault();
            if (genre == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                return genre;
            }
        }
        public int PlaysInDatabase()
        {
            var songs = songRepository.GetAll().ToList();
            if (songs == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                var plays = 0;
                foreach (var song in songs)
                {
                    plays += song.Plays;
                }
                return plays;
            }
        }
        public IEnumerable<Genres> GetGenres()
        {
            var songs = songRepository.GetAll().ToList();

            if (songs == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                var genres = new List<Genres>();

                foreach (var song in songs)
                {
                    genres.Add(song.SongGenre);
                }
                return genres.Distinct();
            }
        }
        public IEnumerable<PlaysByGenres> GenresOrderedByPlays()
        {
            var songs = songRepository.GetAll().ToList();

            if (songs == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                var genres = from x in songs
                             group x by x.SongGenre into g
                             select new PlaysByGenres
                             {
                                 Genre = g.Key,
                                 Plays = g.Sum(x => x.Plays)
                             };

                return genres;
            }
        }
    }
}
