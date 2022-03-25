using C9VLNK_HFT_2021221.Logic;
using C9VLNK_HFT_2021221.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace C9VLNK_HFT_2021221.Endpoint.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class StatController : ControllerBase
    {
        IArtistLogic artistLogic;
        IAlbumLogic albumLogic;
        ISongLogic songLogic;
        public StatController(IArtistLogic artistLogic, IAlbumLogic albumLogic, ISongLogic songLogic)
        {
            this.artistLogic = artistLogic;
            this.albumLogic = albumLogic;
            this.songLogic = songLogic;
        }

        // GET: stat/mostsuccessfulartist
        [HttpGet]
        public Artist MostSuccessfulArtist()
        {
            return artistLogic.MostSuccessfulArtist();
        }


        // GET: stat/listartistsbyplays
        [HttpGet]
        public IEnumerable<ArtistByPlays> ListArtistsByPlays()
        {
            return artistLogic.ListArtistsByPlays();
        }


        // GET: stat/listcountriesbyplays
        [HttpGet]
        public IEnumerable<CountriesByPlays> ListCountriesByPlays()
        {
            return artistLogic.ListCountriesByPlays();
        }

        [Route("getalbumplays/{artistId}")]
        [HttpGet("{artistId}")]
        public int? GetPlays(int artistId)
        {
            return artistLogic.GetArtistPlays(artistId);
        }

        // GET api/album/
        [Route("getplays/{albumId}")]
        [HttpGet("{albumId}")]
        public int? GetAlbumPlays(int albumId)
        {
            return albumLogic.GetAlbumPlays(albumId);
        }

        [Route("getsongplays/{songId}")]
        [HttpGet("{songId}")]
        public int GetSongPlays(int songId)
        {
            return songLogic.GetSongPlays(songId);
        }

        //[Route("albumwiththemostplays")]
        [HttpGet]
        public Album AlbumWithTheMostPlays()
        {
            return albumLogic.AlbumWithTheMostPlays();
        }


        //[Route("albumsorderedbyplays")]
        [HttpGet]
        public IEnumerable<AlbumByPlays> AlbumsOrderedByPlays()
        {
            return albumLogic.AlbumsOrderedByPlays();
        }

        //[Route("albumsorderedbyreleasedate")]
        [HttpGet]
        public IEnumerable<Album> AlbumsOrderedByReleaseDate()
        {
            return albumLogic.AlbumsOrderedByReleaseDate();
        }


        [HttpGet]
        public IEnumerable<Genres> GetGenres()
        {
            return songLogic.GetGenres();
        }



        [HttpGet]
        public PlaysByGenres MostPlayedGenre()
        {
            return songLogic.MostPlayedGenre();
        }

        [HttpGet]
        public IEnumerable<PlaysByGenres> GenresOrderedByPlays()
        {
            return songLogic.GenresOrderedByPlays();
        }

        [HttpGet]
        public IEnumerable<AvarageSongAmountPerArtist> ArtistAvrageSongAmount()
        {
            return artistLogic.ArtistAvrageSongAmount();
        }

        [HttpGet]
        public int PlaysInTheDataBase()
        {
            return songLogic.PlaysInDatabase();
        }


        [Route("genrefilter/{genre}")]
        [HttpGet("{genre}")]
        public IEnumerable<ArtistAndSelectedGenreSongs> GenreFilter(Genres genre)
        {
            return artistLogic.GenreFilter(genre);
        }
    }
}
