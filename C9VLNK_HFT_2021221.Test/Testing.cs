using C9VLNK_HFT_2021221.Logic;
using C9VLNK_HFT_2021221.Models;
using C9VLNK_HFT_2021221.Repository.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Linq;

namespace C9VLNK_HFT_2021221.Test
{
    [TestFixture]
    public partial class Testing
    {
        private IArtistLogic ArtistLogic { get; set; }
        private IAlbumLogic AlbumLogic { get; set; }
        private ISongLogic SongLogic { get; set; }

        [SetUp]
        public void Setup()
        {
            Mock<IArtistRepository> mockedArtisRepository = new Mock<IArtistRepository>();
            Mock<IAlbumRepository> mockedAlbumRepository = new Mock<IAlbumRepository>();
            Mock<ISongRepository> mockedSongRepository = new Mock<ISongRepository>();

            mockedArtisRepository.Setup(x => x.GetAll()).Returns(FakeArtistObjects);
            mockedArtisRepository.Setup(x => x.GetOne(It.IsAny<int>())).Returns(
                new Artist()
                {
                    ArtistGenre = Genres.Indie,
                    ArtistId = 1,
                    Name = "Mac Demarco",
                    Country = Countries.Canada
                });

            mockedAlbumRepository.Setup(x => x.GetAll()).Returns(FakeAlbumObjects);
            mockedAlbumRepository.Setup(x => x.GetOne(It.IsAny<int>())).Returns(
                new Album()
                {
                    AlbumId = 1,
                    AlbumTitle = "This Old Dog",
                    ReleaseDate = new DateTime(2017, 10, 10)
                });

            mockedSongRepository.Setup(x => x.GetAll()).Returns(FakeSongObjects);

            mockedSongRepository.Setup(x => x.GetOne(It.IsAny<int>())).Returns(
                new Song()
                {
                    SongGenre = Genres.Alternative,
                    SongId = 8,
                    Title = "Asszonygyilkosság",
                    Length = new TimeSpan(00, 04, 01),
                    Plays = 868000,
                    Producer = "Dragos Chiriac",
                    ReleaseDate = new DateTime(2019, 10, 10)
                });

            ArtistLogic = new ArtistLogic(mockedArtisRepository.Object, mockedAlbumRepository.Object, mockedSongRepository.Object);
            AlbumLogic = new AlbumLogic(mockedAlbumRepository.Object, mockedSongRepository.Object);
            SongLogic = new SongLogic(mockedSongRepository.Object);

        }
        [TestCase(1, "Mac Demarco")]
        public void GetArtist_ReturnsCorrectInstance(int id, string expectedName)
        {

            var artist = ArtistLogic.GetArtist(id);

            Assert.That(artist.Name, Is.EqualTo(expectedName));
        }

        [TestCase(1, "This Old Dog")]
        public void GetAlbum_ReturnsCorrectInstance(int id, string expectedTitle)
        {
            var album = AlbumLogic.GetAlbum(id);

            Assert.That(album.AlbumTitle, Is.EqualTo(expectedTitle));
        }

        [TestCase(8, "Asszonygyilkosság")]
        public void GetSong_ReturnsCorrectInstance(int id, string expectedTitle)
        {
            var song = SongLogic.GetSong(id);

            Assert.That(song.Title, Is.EqualTo(expectedTitle));
        }

        [TestCase(4)]
        public void GetAllArtist_ReturnsExactNumberOfInstances(int exactNumberOfArtists)
        {
            Assert.That(ArtistLogic.ReadAllArtis().Count(), Is.EqualTo(exactNumberOfArtists));
        }

        [TestCase(4)]
        public void GetAllAlbum_ReturnsExactNumberOfInstances(int exactNumberOfAlbums)
        {
            Assert.That(AlbumLogic.ReadAllAlbums().Count(), Is.EqualTo(exactNumberOfAlbums));
        }

        [TestCase(12)]
        public void GetAllSongs_ReturnsExactNumberOfInstances(int exactNumberOfSongs)
        {
            Assert.That(SongLogic.ReadAllSongs().Count(), Is.EqualTo(exactNumberOfSongs));
        }



        [TestCase("Mac Demarco")]
        public void MostSuccsesfullArtist_ReturnsCorrectAnswer(string expectedArtistName)
        {
            Assert.That(ArtistLogic.MostSuccessfulArtist().Name, Is.EqualTo(expectedArtistName));
        }



        [TestCase("Mac Demarco", "Discolosure")]
        public void ListArtistsByPlays_ReturnsCorrectOrder(string expectedFirstArtistName, string expectedLastArtistName)
        {

            var orderedList = ArtistLogic.ListArtistsByPlays();

            var firstArtist = orderedList.First().ArtistName;
            var lastArtist = orderedList.Last().ArtistName;

            Assert.That(firstArtist + lastArtist, Is.EqualTo(expectedFirstArtistName + expectedLastArtistName));
        }


        [TestCase("Canada")]
        public void MostFamousCountryByPlays_ReturnsCorrectCountry(string expectedCountry)
        {

            var firstCountry = ArtistLogic.ListCountriesByPlays().First().CountryName;

            Assert.That(firstCountry, Is.EqualTo(expectedCountry));
        }


        [TestCase("Canada")]
        public void MostFamousCountryByArtistsCount_ReturnsCorrectCountry(string expectedCountry)
        {

            var firstCountry = ArtistLogic.MostFamousCountryByArtistsCount();

            Assert.That(firstCountry, Is.EqualTo(expectedCountry));
        }

        [TestCase("This Old Dog")]
        public void AlbumWithTheMostPlays_ReturnsCorrectInstances(string expectedAlbumTitle)
        {

            var mostPlayedAlbum = AlbumLogic.AlbumWithTheMostPlays();

            Assert.That(mostPlayedAlbum.AlbumTitle, Is.EqualTo(expectedAlbumTitle));
        }


        [TestCase("This Old Dog", "ENERGY(DELUXE)")]
        public void AlbumsOrderedByPlays_ReturnsCorrectOrder(string expectedFirstAlbumName, string expectedLastAlbumName)
        {

            var orderedAlbumList = AlbumLogic.AlbumsOrderedByPlays();

            var firstAlbum = orderedAlbumList.First();
            var lastAlbum = orderedAlbumList.Last();

            Assert.That(firstAlbum.AlbumTitle + lastAlbum.AlbumTitle, Is.EqualTo(expectedFirstAlbumName + expectedLastAlbumName));
        }


        [TestCase("ENERGY(DELUXE)", "na ná ba bám")]
        public void AlbumsOrderedByReleaseDate_ReturnsCorrectInstances(string expectedFirstAlbumName, string expectedLastAlbumName)
        {

            var orderedAlbumList = AlbumLogic.AlbumsOrderedByReleaseDate();

            var firstAlbum = orderedAlbumList.First();
            var lastAlbum = orderedAlbumList.Last();

            Assert.That(firstAlbum.AlbumTitle + lastAlbum.AlbumTitle, Is.EqualTo(expectedFirstAlbumName + expectedLastAlbumName));
        }

        //CREATE TESTS 
        [TestCase]
        public void AddNullArtist_ThrowsException()
        {
            Assert.Throws(typeof(NullReferenceException), () => ArtistLogic.AddArtist(null));
        }

        [Test]
        public void AddArtistWithoutName_ThrowsException()
        {
            var artist = new Artist()
            {
                ArtistId = 4,
                Country = Countries.Chad,
                ArtistGenre = Genres.Rock
            };

            Assert.Throws(typeof(NullReferenceException), () => ArtistLogic.AddArtist(artist));
        }

        [Test]
        public void AddNullAlbum_ThrowsException()
        {
            Assert.Throws(typeof(NullReferenceException), () => AlbumLogic.AddAlbum(null));
        }

        [Test]
        public void AddAlbumWithoutTitle_ThrowsException()
        {
            var album = new Album()
            {
                ReleaseDate = DateTime.Now,

            };

            Assert.Throws(typeof(NullReferenceException), () => AlbumLogic.AddAlbum(album));
        }

        [Test]
        public void AddNullSong_ThrowsException()
        {
            Assert.Throws(typeof(NullReferenceException), () => SongLogic.AddSong(null));
        }

        [Test]
        public void AddSongWithoutTitle_ThrowsException()
        {
            var song = new Song()
            {
                ReleaseDate = DateTime.Now,

            };

            Assert.Throws(typeof(NullReferenceException), () => SongLogic.AddSong(song));
        }

        [TestCase("Indie", 2)]
        public void GenreFilterNonCrud_ReturnsCorrectInstances(Genres genre, int countValue)
        {
            var list = ArtistLogic.GenreFilter(genre);
            Assert.That(list.Count, Is.EqualTo(countValue));
        }

        [TestCase(3)]
        public void ArtistAvrageSongAmount_ReturnsCorrectInstances(int avgValue)
        {
            var list = ArtistLogic.ArtistAvrageSongAmount();
            Assert.That(list.First().AverageAmount, Is.EqualTo(avgValue));
        }


        [TestCase("Canada")]
        public void ListCountriesByPlays_ReturnsCorrectInstances(string correctFirstMockCountry)
        {
            var firstCountry = ArtistLogic.ListCountriesByPlays().First();
            Assert.That(firstCountry.CountryName, Is.EqualTo(correctFirstMockCountry));

        }
    }

}