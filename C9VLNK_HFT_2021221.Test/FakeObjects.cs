using C9VLNK_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace C9VLNK_HFT_2021221.Test
{
    public partial class Testing
    {
        public IQueryable<Artist> FakeArtistObjects()
        {
            Artist a0 = new Artist()
            {
                ArtistGenre = Genres.Indie,
                ArtistId = 1,
                Name = "Mac Demarco",
                Country = Countries.Canada
            };


            Artist a1 = new Artist() { ArtistGenre = Genres.Pop, ArtistId = 2, Name = "Man I Trust", Country = Countries.Canada };


            Artist a2 = new Artist() { ArtistGenre = Genres.Alternative, ArtistId = 3, Name = "Csaknekedkislány", Country = Countries.Canada };

            Artist a3 = new Artist() { ArtistGenre = Genres.Edm, ArtistId = 4, Name = "Discolosure", Country = Countries.UnitedKingdom };


            //ALBUMS ###########################################################################################################################

            Album b0 = new Album()
            {
                AlbumId = 1,
                AlbumTitle = "This Old Dog",
                /*NumberOfSongs = 12,*/
                ReleaseDate = new DateTime(2017, 10, 10)
            };


            Album b1 = new Album() { AlbumId = 2, AlbumTitle = "Oncle Jazz", /*NumberOfSongs = 24,*/ ReleaseDate = new DateTime(2019, 12, 10) };


            Album b2 = new Album() { AlbumId = 3, AlbumTitle = "na ná ba bám", /*NumberOfSongs = 14,*/ ReleaseDate = new DateTime(2015, 01, 10) };

            Album b3 = new Album() { AlbumId = 4, AlbumTitle = "ENERGY(DELUXE)", /*NumberOfSongs = 14,*/ ReleaseDate = new DateTime(2020, 07, 02) };
            //SONGS ###########################################################################################################################


            Song s0 = new Song()
            {
                SongGenre = Genres.Indie,
                SongId = 1,
                Title = "One Another",
                Length = new TimeSpan(00, 02, 36),
                Plays = 25000000,
                Producer = "Mac Demarco",
                ReleaseDate = new DateTime(2017, 10, 10)
            };

            Song s1 = new Song() { SongGenre = Genres.Indie, SongId = 2, Title = "One More Love Song", Length = new TimeSpan(00, 04, 01), Plays = 37000000, Producer = "Mac Demarco", ReleaseDate = new DateTime(2017, 10, 10), };

            Song s2 = new Song() { SongGenre = Genres.Indie, SongId = 3, Title = "On The Level", Length = new TimeSpan(00, 03, 47), Plays = 51000000, Producer = "Mac Demarco", ReleaseDate = new DateTime(2017, 10, 10) };


            Song s3 = new Song() { SongGenre = Genres.Indie, SongId = 4, Title = "Days Go By", Length = new TimeSpan(00, 02, 36), Plays = 4000000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 12, 10) };

            Song s4 = new Song() { SongGenre = Genres.Pop, SongId = 5, Title = "Numb", Length = new TimeSpan(00, 04, 01), Plays = 2000000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 10, 10), };

            Song s5 = new Song() { SongGenre = Genres.Pop, SongId = 6, Title = "Show Me How", Length = new TimeSpan(00, 03, 47), Plays = 4000000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 10, 10) };


            Song s6 = new Song() { SongGenre = Genres.Alternative, SongId = 7, Title = "Tihany", Length = new TimeSpan(00, 02, 36), Plays = 1268000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 12, 10) };

            Song s7 = new Song() { SongGenre = Genres.Alternative, SongId = 8, Title = "Asszonygyilkosság", Length = new TimeSpan(00, 04, 01), Plays = 868000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 10, 10), };

            Song s8 = new Song() { SongGenre = Genres.Alternative, SongId = 9, Title = "Falábú nő", Length = new TimeSpan(00, 03, 47), Plays = 968000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 10, 10) };



            Song s9 = new Song() { SongGenre = Genres.Edm, SongId = 10, Title = "Levander", Length = new TimeSpan(00, 04, 49), Plays = 1268000, Producer = "Disclosure", ReleaseDate = new DateTime(2020, 07, 02) };

            Song s10 = new Song() { SongGenre = Genres.Edm, SongId = 11, Title = "My High", Length = new TimeSpan(00, 04, 45), Plays = 868000, Producer = "Disclosure", ReleaseDate = new DateTime(2020, 07, 02) };

            Song s11 = new Song() { SongGenre = Genres.Edm, SongId = 12, Title = "Talk", Length = new TimeSpan(00, 03, 17), Plays = 30000, Producer = "Disclosure", ReleaseDate = new DateTime(2020, 07, 02) };

            // ###########################################################################################################################

            // MAC DEMARCO OLD DOG 
            //"Song"-s hozzáadása "Album"-hoz
            s0.AlbumId = b0.AlbumId;
            s1.AlbumId = b0.AlbumId;
            s2.AlbumId = b0.AlbumId;

            // Man I Trust
            s3.AlbumId = b1.AlbumId;
            s4.AlbumId = b1.AlbumId;
            s5.AlbumId = b1.AlbumId;

            // Csaknekedkislány
            s6.AlbumId = b2.AlbumId;
            s7.AlbumId = b2.AlbumId;
            s8.AlbumId = b2.AlbumId;

            //Disclosure
            s9.AlbumId = b3.AlbumId;
            s10.AlbumId = b3.AlbumId;
            s11.AlbumId = b3.AlbumId;

            ////"Album" hozzáadása "Artist"-hoz
            b0.ArtistId = a0.ArtistId;
            b1.ArtistId = a1.ArtistId;
            b2.ArtistId = a2.ArtistId;
            b3.ArtistId = a3.ArtistId;


            b0.Artist = a0;
            b1.Artist = a1;
            b2.Artist = a2;
            b3.Artist = a3;

            s0.Album = b0;
            s1.Album = b0;
            s2.Album = b0;

            s3.Album = b1;
            s4.Album = b1;
            s5.Album = b1;

            s6.Album = b2;
            s7.Album = b2;
            s8.Album = b2;

            s9.Album = b3;
            s10.Album = b3;
            s11.Album = b3;


            a0.Albums = new List<Album>() { b0 };
            a1.Albums = new List<Album>() { b1 };
            a2.Albums = new List<Album>() { b2 };
            a3.Albums = new List<Album>() { b3 };

            b0.Songs = new List<Song>() { s0, s1, s2 };
            b1.Songs = new List<Song>() { s3, s4, s5 };
            b2.Songs = new List<Song>() { s6, s7, s8 };
            b3.Songs = new List<Song>() { s9, s10, s11 };


            List<Artist> items = new List<Artist>()
            {
                a0,
                a1,
                a2,
                a3
            };

            return items.AsQueryable();


        }
        public IQueryable<Album> FakeAlbumObjects()
        {
            Artist a0 = new Artist()
            {
                ArtistGenre = Genres.Indie,
                ArtistId = 1,
                Name = "Mac Demarco",
                Country = Countries.Canada
            };


            Artist a1 = new Artist() { ArtistGenre = Genres.Pop, ArtistId = 2, Name = "Man I Trust", Country = Countries.Canada };

            Artist a2 = new Artist() { ArtistGenre = Genres.Alternative, ArtistId = 3, Name = "Csaknekedkislány", Country = Countries.Hungary};

            Artist a3 = new Artist() { ArtistGenre = Genres.Edm, ArtistId = 4, Name = "Discolosure", Country = Countries.UnitedKingdom };


            //ALBUMS ###########################################################################################################################

            Album b0 = new Album()
            {
                AlbumId = 1,
                AlbumTitle = "This Old Dog",
                /*NumberOfSongs = 12,*/
                ReleaseDate = new DateTime(2017, 10, 10)
            };


            Album b1 = new Album() { AlbumId = 2, AlbumTitle = "Oncle Jazz", /*NumberOfSongs = 24,*/ ReleaseDate = new DateTime(2019, 12, 10) };


            Album b2 = new Album() { AlbumId = 3, AlbumTitle = "na ná ba bám", /*NumberOfSongs = 14,*/ ReleaseDate = new DateTime(2015, 01, 10) };

            Album b3 = new Album() { AlbumId = 4, AlbumTitle = "ENERGY(DELUXE)", /*NumberOfSongs = 14,*/ ReleaseDate = new DateTime(2020, 07, 02) };
            //SONGS ###########################################################################################################################


            Song s0 = new Song()
            {
                SongGenre = Genres.Indie,
                SongId = 1,
                Title = "One Another",
                Length = new TimeSpan(00, 02, 36),
                Plays = 25000000,
                Producer = "Mac Demarco",
                ReleaseDate = new DateTime(2017, 10, 10)
            };

            Song s1 = new Song() { SongGenre = Genres.Indie, SongId = 2, Title = "One More Love Song", Length = new TimeSpan(00, 04, 01), Plays = 37000000, Producer = "Mac Demarco", ReleaseDate = new DateTime(2017, 10, 10), };

            Song s2 = new Song() { SongGenre = Genres.Indie, SongId = 3, Title = "On The Level", Length = new TimeSpan(00, 03, 47), Plays = 51000000, Producer = "Mac Demarco", ReleaseDate = new DateTime(2017, 10, 10) };


            Song s3 = new Song() { SongGenre = Genres.Indie, SongId = 4, Title = "Days Go By", Length = new TimeSpan(00, 02, 36), Plays = 4000000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 12, 10) };

            Song s4 = new Song() { SongGenre = Genres.Pop, SongId = 5, Title = "Numb", Length = new TimeSpan(00, 04, 01), Plays = 2000000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 10, 10), };

            Song s5 = new Song() { SongGenre = Genres.Pop, SongId = 6, Title = "Show Me How", Length = new TimeSpan(00, 03, 47), Plays = 4000000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 10, 10) };


            Song s6 = new Song() { SongGenre = Genres.Alternative, SongId = 7, Title = "Tihany", Length = new TimeSpan(00, 02, 36), Plays = 1268000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 12, 10) };

            Song s7 = new Song() { SongGenre = Genres.Alternative, SongId = 8, Title = "Asszonygyilkosság", Length = new TimeSpan(00, 04, 01), Plays = 868000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 10, 10), };

            Song s8 = new Song() { SongGenre = Genres.Alternative, SongId = 9, Title = "Falábú nő", Length = new TimeSpan(00, 03, 47), Plays = 968000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 10, 10) };



            Song s9 = new Song() { SongGenre = Genres.Edm, SongId = 10, Title = "Levander", Length = new TimeSpan(00, 04, 49), Plays = 1268000, Producer = "Disclosure", ReleaseDate = new DateTime(2020, 07, 02) };

            Song s10 = new Song() { SongGenre = Genres.Edm, SongId = 11, Title = "My High", Length = new TimeSpan(00, 04, 45), Plays = 868000, Producer = "Disclosure", ReleaseDate = new DateTime(2020, 07, 02) };

            Song s11 = new Song() { SongGenre = Genres.Edm, SongId = 12, Title = "Talk", Length = new TimeSpan(00, 03, 17), Plays = 30000, Producer = "Disclosure", ReleaseDate = new DateTime(2020, 07, 02) };

            // ###########################################################################################################################

            // MAC DEMARCO OLD DOG 
            //"Song"-s hozzáadása "Album"-hoz
            s0.AlbumId = b0.AlbumId;
            s1.AlbumId = b0.AlbumId;
            s2.AlbumId = b0.AlbumId;

            // Man I Trust
            s3.AlbumId = b1.AlbumId;
            s4.AlbumId = b1.AlbumId;
            s5.AlbumId = b1.AlbumId;

            // Csaknekedkislány
            s6.AlbumId = b2.AlbumId;
            s7.AlbumId = b2.AlbumId;
            s8.AlbumId = b2.AlbumId;

            //Disclosure
            s9.AlbumId = b3.AlbumId;
            s10.AlbumId = b3.AlbumId;
            s11.AlbumId = b3.AlbumId;

            ////"Album" hozzáadása "Artist"-hoz
            b0.ArtistId = a0.ArtistId;
            b1.ArtistId = a1.ArtistId;
            b2.ArtistId = a2.ArtistId;
            b3.ArtistId = a3.ArtistId;

            b0.Artist = a0;
            b1.Artist = a1;
            b2.Artist = a2;
            b3.Artist = a3;

            s0.Album = b0;
            s1.Album = b0;
            s2.Album = b0;

            s3.Album = b1;
            s4.Album = b1;
            s5.Album = b1;

            s6.Album = b2;
            s7.Album = b2;
            s8.Album = b2;

            s9.Album = b3;
            s10.Album = b3;
            s11.Album = b3;


            a0.Albums = new List<Album>() { b0 };
            a1.Albums = new List<Album>() { b1 };
            a2.Albums = new List<Album>() { b2 };
            a3.Albums = new List<Album>() { b3 };

            b0.Songs = new List<Song>() { s0, s1, s2 };
            b1.Songs = new List<Song>() { s3, s4, s5 };
            b2.Songs = new List<Song>() { s6, s7, s8 };
            b3.Songs = new List<Song>() { s9, s10, s11 };


            List<Album> items = new List<Album>() { b0, b1, b2, b3 };

            return items.AsQueryable();
        }
        public IQueryable<Song> FakeSongObjects()
        {
            Artist a0 = new Artist()
            {
                ArtistGenre = Genres.Indie,
                ArtistId = 1,
                Name = "Mac Demarco",
                Country = Countries.Canada
            };


            Artist a1 = new Artist() { ArtistGenre = Genres.Pop, ArtistId = 2, Name = "Man I Trust", Country = Countries.Canada };


            Artist a2 = new Artist() { ArtistGenre = Genres.Alternative, ArtistId = 3, Name = "Csaknekedkislány", Country = Countries.Hungary };

            Artist a3 = new Artist() { ArtistGenre = Genres.Edm, ArtistId = 4, Name = "Discolosure", Country = Countries.UnitedKingdom};


            //ALBUMS ###########################################################################################################################

            Album b0 = new Album()
            {
                AlbumId = 1,
                AlbumTitle = "This Old Dog",
                /*NumberOfSongs = 12,*/
                ReleaseDate = new DateTime(2017, 10, 10)
            };


            Album b1 = new Album() { AlbumId = 2, AlbumTitle = "Oncle Jazz", /*NumberOfSongs = 24,*/ ReleaseDate = new DateTime(2019, 12, 10) };


            Album b2 = new Album() { AlbumId = 3, AlbumTitle = "na ná ba bám", /*NumberOfSongs = 14,*/ ReleaseDate = new DateTime(2015, 01, 10) };

            Album b3 = new Album() { AlbumId = 4, AlbumTitle = "ENERGY(DELUXE)", /*NumberOfSongs = 14,*/ ReleaseDate = new DateTime(2020, 07, 02) };
            //SONGS ###########################################################################################################################


            Song s0 = new Song()
            {
                SongGenre = Genres.Indie,
                SongId = 1,
                Title = "One Another",
                Length = new TimeSpan(00, 02, 36),
                Plays = 25000000,
                Producer = "Mac Demarco",
                ReleaseDate = new DateTime(2017, 10, 10)
            };

            Song s1 = new Song() { SongGenre = Genres.Indie, SongId = 2, Title = "One More Love Song", Length = new TimeSpan(00, 04, 01), Plays = 37000000, Producer = "Mac Demarco", ReleaseDate = new DateTime(2017, 10, 10), };

            Song s2 = new Song() { SongGenre = Genres.Indie, SongId = 3, Title = "On The Level", Length = new TimeSpan(00, 03, 47), Plays = 51000000, Producer = "Mac Demarco", ReleaseDate = new DateTime(2017, 10, 10) };


            Song s3 = new Song() { SongGenre = Genres.Indie, SongId = 4, Title = "Days Go By", Length = new TimeSpan(00, 02, 36), Plays = 4000000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 12, 10) };

            Song s4 = new Song() { SongGenre = Genres.Pop, SongId = 5, Title = "Numb", Length = new TimeSpan(00, 04, 01), Plays = 2000000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 10, 10), };

            Song s5 = new Song() { SongGenre = Genres.Pop, SongId = 6, Title = "Show Me How", Length = new TimeSpan(00, 03, 47), Plays = 4000000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 10, 10) };


            Song s6 = new Song() { SongGenre = Genres.Alternative, SongId = 7, Title = "Tihany", Length = new TimeSpan(00, 02, 36), Plays = 1268000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 12, 10) };

            Song s7 = new Song() { SongGenre = Genres.Alternative, SongId = 8, Title = "Asszonygyilkosság", Length = new TimeSpan(00, 04, 01), Plays = 868000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 10, 10), };

            Song s8 = new Song() { SongGenre = Genres.Alternative, SongId = 9, Title = "Falábú nő", Length = new TimeSpan(00, 03, 47), Plays = 968000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 10, 10) };



            Song s9 = new Song() { SongGenre = Genres.Edm, SongId = 10, Title = "Levander", Length = new TimeSpan(00, 04, 49), Plays = 1268000, Producer = "Disclosure", ReleaseDate = new DateTime(2020, 07, 02) };

            Song s10 = new Song() { SongGenre = Genres.Edm, SongId = 11, Title = "My High", Length = new TimeSpan(00, 04, 45), Plays = 868000, Producer = "Disclosure", ReleaseDate = new DateTime(2020, 07, 02) };

            Song s11 = new Song() { SongGenre = Genres.Edm, SongId = 12, Title = "Talk", Length = new TimeSpan(00, 03, 17), Plays = 30000, Producer = "Disclosure", ReleaseDate = new DateTime(2020, 07, 02) };

            // ###########################################################################################################################

            // MAC DEMARCO OLD DOG 
            //"Song"-s hozzáadása "Album"-hoz
            s0.AlbumId = b0.AlbumId;
            s1.AlbumId = b0.AlbumId;
            s2.AlbumId = b0.AlbumId;

            // Man I Trust
            s3.AlbumId = b1.AlbumId;
            s4.AlbumId = b1.AlbumId;
            s5.AlbumId = b1.AlbumId;

            // Csaknekedkislány
            s6.AlbumId = b2.AlbumId;
            s7.AlbumId = b2.AlbumId;
            s8.AlbumId = b2.AlbumId;

            //Disclosure
            s9.AlbumId = b3.AlbumId;
            s10.AlbumId = b3.AlbumId;
            s11.AlbumId = b3.AlbumId;

            ////"Album" hozzáadása "Artist"-hoz
            b0.ArtistId = a0.ArtistId;
            b1.ArtistId = a1.ArtistId;
            b2.ArtistId = a2.ArtistId;
            b3.ArtistId = a3.ArtistId;

            b0.Artist = a0;
            b1.Artist = a1;
            b2.Artist = a2;
            b3.Artist = a3;

            s0.Album = b0;
            s1.Album = b0;
            s2.Album = b0;

            s3.Album = b1;
            s4.Album = b1;
            s5.Album = b1;

            s6.Album = b2;
            s7.Album = b2;
            s8.Album = b2;

            s9.Album = b3;
            s10.Album = b3;
            s11.Album = b3;

            a0.Albums = new List<Album>() { b0 };
            a1.Albums = new List<Album>() { b1 };
            a2.Albums = new List<Album>() { b2 };
            a3.Albums = new List<Album>() { b3 };

            b0.Songs = new List<Song>() { s0, s1, s2 };
            b1.Songs = new List<Song>() { s3, s4, s5 };
            b2.Songs = new List<Song>() { s6, s7, s8 };
            b3.Songs = new List<Song>() { s9, s10, s11 };

            List<Song> items = new List<Song>()
            {
                s0, s1, s2,
                s3, s4, s5,
                s6, s7, s8,
                s9, s10, s11
            };

            return items.AsQueryable();
        }

    }
}