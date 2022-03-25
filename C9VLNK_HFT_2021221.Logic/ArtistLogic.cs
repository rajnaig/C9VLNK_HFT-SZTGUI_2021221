using C9VLNK_HFT_2021221.Models;
using C9VLNK_HFT_2021221.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace C9VLNK_HFT_2021221.Logic
{
    public interface IArtistLogic
    {
        //CRUD
        void AddArtist(Artist artist);
        Artist GetArtist(int artistId);
        //READ
        int? GetArtistPlays(int artistId);
        IQueryable<Artist> ReadAllArtis();

        void UpdateArtistName(int artistId, string newName);
        void UpdateArtistCountry(int artistId, Countries newCountry);
        void UpdateFullArtist(Artist artist);
        void DeleteArtist(int artistId);
        //NON-CRUD
        Artist MostSuccessfulArtist();
        string MostFamousCountryByArtistsCount();
        IEnumerable<CountriesByPlays> ListCountriesByPlays();
        IEnumerable<ArtistByPlays> ListArtistsByPlays();
        IEnumerable<AvarageSongAmountPerArtist> ArtistAvrageSongAmount();
        IEnumerable<ArtistAndSelectedGenreSongs> GenreFilter(Genres genre);
    }
    public class ArtistLogic : IArtistLogic
    {
        IArtistRepository artistRepository;
        IAlbumRepository albumRepository;
        ISongRepository songRepository;

        public ArtistLogic(IArtistRepository artistRepository, IAlbumRepository albumRepository, ISongRepository songRepository)
        {
            this.artistRepository = artistRepository;
            this.albumRepository = albumRepository;
            this.songRepository = songRepository;
        }
        public void AddArtist(Artist artist)
        {

            if (artist == null || artist.Name == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                this.artistRepository.AddArtist(artist);
            }
        }
        public void DeleteArtist(int artistId)
        {
            var toBeDeleted = GetArtist(artistId);

            if (toBeDeleted == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                artistRepository.DeleteArtist(artistId);
            }
        }
        public Artist GetArtist(int artistId)
        {
            var artist = artistRepository.GetOne(artistId);
            return artist;
        }
        public string MostFamousCountryByArtistsCount()
        {
            var country = (from x in artistRepository.GetAll()
                           group x by x.Country into g
                           orderby g.Count() descending
                           select new
                           {
                               Country = g.Key,
                               ArtistCount = g.Count()
                           }).FirstOrDefault().Country;


            if (country == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                return country.ToString();
            }
        }
        public IEnumerable<CountriesByPlays> ListCountriesByPlays()
        {
            var country = (from x in artistRepository.GetAll()
                           join y in albumRepository.GetAll() on x.ArtistId equals y.ArtistId
                           join z in songRepository.GetAll() on y.AlbumId equals z.AlbumId
                           group new { x, y, z } by x.Country into g
                           select new CountriesByPlays
                           {
                               CountryName = g.Key,
                               Plays = g.Sum(x => x.z.Plays)
                           }).OrderByDescending(x => x.Plays);
            return country;


        }
        public IQueryable<Artist> ReadAllArtis()
        {
            var artists = artistRepository.GetAll();
            if (artists == null)
            {
                throw new NullReferenceException();

            }
            else
            {
                return artists;
            }
        }
        public void UpdateArtistName(int artistId, string newName)
        {
            var artist = GetArtist(artistId);
            if (artist == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                artistRepository.UpdateArtistName(artistId, newName);
            }

        }
        public void UpdateArtistCountry(int artistId, Countries newCountry)
        {
            var artist = GetArtist(artistId);
            if (artist == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                artistRepository.UpdateArtistNationality(artistId, newCountry);
            }
        }
        public void UpdateFullArtist(Artist artist)
        {
            var toUpdateArtist = GetArtist(artist.ArtistId);
            if (toUpdateArtist == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                artistRepository.UpdateFullArtist(artist);
            }

        }
        public Artist MostSuccessfulArtist()
        {
            var id = ListArtistsByPlays().FirstOrDefault().ArtistId;
            return GetArtist(id);
        }
        public IEnumerable<ArtistByPlays> ListArtistsByPlays()
        {
            var q = (from x in artistRepository.GetAll().ToList()
                     join y in albumRepository.GetAll().ToList() on x.ArtistId equals y.ArtistId
                     join z in songRepository.GetAll().ToList() on y.AlbumId equals z.AlbumId
                     group new { x, y, z } by x into g
                     select new ArtistByPlays
                     {
                         ArtistId = g.Key.ArtistId,
                         ArtistName = g.Key.Name,
                         Plays = g.Sum(x => x.z.Plays)

                     }).OrderByDescending(x => x.Plays);

            return q;

        }
        public int? GetArtistPlays(int artistId)
        {

            var plays = (from x in ListArtistsByPlays()
                         where x.ArtistId == artistId
                         select x.Plays).FirstOrDefault();

            return plays;
        }
        public IEnumerable<AvarageSongAmountPerArtist> ArtistAvrageSongAmount()
        {
            var AVGSongAmountList = (from x in artistRepository.GetAll().ToList()
                                     join y in albumRepository.GetAll().ToList() on x.ArtistId equals y.ArtistId
                                     join z in songRepository.GetAll().ToList() on y.AlbumId equals z.AlbumId
                                     group new { x, y, z } by x into g
                                     select new AvarageSongAmountPerArtist
                                     {
                                         ArtistId = g.Key.ArtistId,
                                         ArtistName = g.Key.Name,
                                         AverageAmount = g.Average(x => x.y.Songs.Count())
                                     }).OrderByDescending(x => x.AverageAmount);

            return AVGSongAmountList;

        }
        public IEnumerable<ArtistAndSelectedGenreSongs> GenreFilter(Genres genre)
        {
            var q = (from x in artistRepository.GetAll().ToList()
                     join y in albumRepository.GetAll().ToList() on x.ArtistId equals y.ArtistId
                     join z in songRepository.GetAll().ToList() on y.AlbumId equals z.AlbumId
                     where z.SongGenre.Equals(genre)
                     group x by x into g
                     select new ArtistAndSelectedGenreSongs
                     {
                         ArtistId = g.Key.ArtistId,
                         ArtistName = g.Key.Name,
                         FilteredSongs = (songRepository.GetAll()
                             .ToList()
                             .Where(x => (x.Album.ArtistId.Equals(g.Key.ArtistId) && x.SongGenre.Equals(genre))))

                             .ToList()
                     });

            return q;
        }
    }
}
