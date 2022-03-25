using C9VLNK_HFT_2021221.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace C9VLNK_HFT_2021221.Data
{
    public class MusicContext : DbContext
    {
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Song> Songs { get; set; }



        public MusicContext()
        {
            this.Database.EnsureCreated();
        }

        public MusicContext(DbContextOptions<MusicContext> options)
           : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MusicDataBase.mdf;Integrated Security=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Artist a0 = new Artist()
            {
                Country = Countries.Canada,
                ArtistGenre = Genres.Indie,
                ArtistId = 1,
                Name = "Mac Demarco",
                //ProfilPicture = "./Images/MacDemarco.jpg"
                ProfilPicture = @"D:\Egyetem\4.felev\SZTGUI\Féléves Upgrade\C9VLNK_HFT_2021221-master\C9VLNK_HFT_2021221-master\C9VLNK_HFT_20211221.WpfClient\bin\Debug\net5.0-windows\Images\MacDemarco.jpg"
            };


            Artist a1 = new Artist()
            {
                ArtistGenre = Genres.Pop,
                ArtistId = 2,
                Name = "Man I Trust",
                Country = Countries.Canada,
                ProfilPicture = @"D:\Egyetem\4.felev\SZTGUI\Féléves Upgrade\C9VLNK_HFT_2021221-master\C9VLNK_HFT_2021221-master\C9VLNK_HFT_20211221.WpfClient\bin\Debug\net5.0-windows\Images\manitrust.jpg"
            };


            Artist a2 = new Artist()
            {
                ArtistGenre = Genres.Alternative,
                ArtistId = 3,
                Name = "Csaknekedkislány",
                Country = Countries.Hungary,
                ProfilPicture = @"D:\Egyetem\4.felev\SZTGUI\Féléves Upgrade\C9VLNK_HFT_2021221-master\C9VLNK_HFT_2021221-master\C9VLNK_HFT_20211221.WpfClient\bin\Debug\net5.0-windows\Images\csakneked.jpg"
            };

            Artist a3 = new Artist()
            {
                ArtistGenre = Genres.Edm,
                ArtistId = 4,
                Name = "Discolosure",
                Country = Countries.UnitedKingdom,
                ProfilPicture = @"D:\Egyetem\4.felev\SZTGUI\Féléves Upgrade\C9VLNK_HFT_2021221-master\C9VLNK_HFT_2021221-master\C9VLNK_HFT_20211221.WpfClient\bin\Debug\net5.0-windows\Images\disclosure.jpg"
            };

            Artist a4 = new Artist()
            {
                ArtistGenre = Genres.Indie,
                ArtistId = 5,
                Name = "Carson Coma",
                Country = Countries.Hungary,
                ProfilPicture = @"D:\Egyetem\4.felev\SZTGUI\Féléves Upgrade\C9VLNK_HFT_2021221-master\C9VLNK_HFT_2021221-master\C9VLNK_HFT_20211221.WpfClient\bin\Debug\net5.0-windows\Images\carsoncoma.jpg"
            };


            Album b0 = new Album()
            {
                AlbumId = 1,
                AlbumTitle = "This Old Dog",

                ReleaseDate = new DateTime(2017, 10, 10),
                AlbumCover = @"D:\Egyetem\4.felev\SZTGUI\Féléves Upgrade\C9VLNK_HFT_2021221-master\C9VLNK_HFT_2021221-master\C9VLNK_HFT_20211221.WpfClient\bin\Debug\net5.0-windows\Images\MacDeMarcoThisOldDog.png"
            };


            Album b1 = new Album()
            {
                AlbumId = 2,
                AlbumTitle = "Oncle Jazz", /*NumberOfSongs = 24,*/
                ReleaseDate = new DateTime(2019, 12, 10)
            ,
                AlbumCover = @"D:\Egyetem\4.felev\SZTGUI\Féléves Upgrade\C9VLNK_HFT_2021221-master\C9VLNK_HFT_2021221-master\C9VLNK_HFT_20211221.WpfClient\bin\Debug\net5.0-windows\Images\oncle jazz.png"
            };


            Album b2 = new Album()
            {
                AlbumId = 3,
                AlbumTitle = "na ná ba bám", /*NumberOfSongs = 14,*/
                ReleaseDate = new DateTime(2015, 01, 10)
            ,
                AlbumCover = @"D:\Egyetem\4.felev\SZTGUI\Féléves Upgrade\C9VLNK_HFT_2021221-master\C9VLNK_HFT_2021221-master\C9VLNK_HFT_20211221.WpfClient\bin\Debug\net5.0-windows\Images\nanababam.jpg"
            };

            Album b3 = new Album()
            {
                AlbumId = 4,
                AlbumTitle = "ENERGY(DELUXE)",
                /*NumberOfSongs = 14,*/
                ReleaseDate = new DateTime(2020, 07, 02),
                AlbumCover = @"D:\Egyetem\4.felev\SZTGUI\Féléves Upgrade\C9VLNK_HFT_2021221-master\C9VLNK_HFT_2021221-master\C9VLNK_HFT_20211221.WpfClient\bin\Debug\net5.0-windows\Images\energy.jpg"
            };


            Song s0 = new Song()
            {
                SongGenre = Genres.Soul,
                SongId = 1,
                Title = "One Another",
                Length = new TimeSpan(00, 02, 36),
                Plays = 25000000,
                Producer = "Mac Demarco",
                ReleaseDate = new DateTime(2017, 10, 10),
                SongCover = b0.AlbumCover

            };

            Song s1 = new Song()
            {
                SongGenre = Genres.Indie,
                SongId = 2,
                Title = "One More Love Song",
                Length = new TimeSpan(00, 04, 01),
                Plays = 37000000,
                Producer = "Mac Demarco",
                ReleaseDate = new DateTime(2017, 10, 10),
                SongCover = b0.AlbumCover
            };

            Song s2 = new Song() { SongGenre = Genres.Indie, SongId = 3, Title = "On The Level", Length = new TimeSpan(00, 03, 47), Plays = 51000000, Producer = "Mac Demarco", ReleaseDate = new DateTime(2017, 10, 10), SongCover = b0.AlbumCover };


            Song s3 = new Song() { SongGenre = Genres.Indie, SongId = 4, Title = "Days Go By", Length = new TimeSpan(00, 02, 36), Plays = 4000000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 12, 10), SongCover = b1.AlbumCover };

            Song s4 = new Song() { SongGenre = Genres.Indie, SongId = 5, Title = "Numb", Length = new TimeSpan(00, 04, 01), Plays = 2000000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 10, 10), SongCover = b1.AlbumCover };

            Song s5 = new Song() { SongGenre = Genres.Indie, SongId = 6, Title = "Show Me How", Length = new TimeSpan(00, 03, 47), Plays = 4000000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 10, 10), SongCover = b1.AlbumCover };


            Song s6 = new Song() { SongGenre = Genres.Alternative, SongId = 7, Title = "Tihany", Length = new TimeSpan(00, 02, 36), Plays = 1268000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 12, 10), SongCover = b2.AlbumCover };

            Song s7 = new Song() { SongGenre = Genres.Alternative, SongId = 8, Title = "Asszonygyilkosság", Length = new TimeSpan(00, 04, 01), Plays = 868000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 10, 10), SongCover = b2.AlbumCover };

            Song s8 = new Song() { SongGenre = Genres.Alternative, SongId = 9, Title = "Falábú nő", Length = new TimeSpan(00, 03, 47), Plays = 968000, Producer = "Dragos Chiriac", ReleaseDate = new DateTime(2019, 10, 10), SongCover = b2.AlbumCover };



            Song s9 = new Song() { SongGenre = Genres.Edm, SongId = 10, Title = "Levander", Length = new TimeSpan(00, 04, 49), Plays = 1268000, Producer = "Disclosure", ReleaseDate = new DateTime(2020, 07, 02), SongCover = b3.AlbumCover };

            Song s10 = new Song() { SongGenre = Genres.Edm, SongId = 11, Title = "My High", Length = new TimeSpan(00, 04, 45), Plays = 868000, Producer = "Disclosure", ReleaseDate = new DateTime(2020, 07, 02), SongCover = b3.AlbumCover };

            Song s11 = new Song() { SongGenre = Genres.Edm, SongId = 12, Title = "Talk", Length = new TimeSpan(00, 03, 17), Plays = 30000, Producer = "Disclosure", ReleaseDate = new DateTime(2020, 07, 02), SongCover = b3.AlbumCover };


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

            b0.ArtistId = a0.ArtistId;
            b1.ArtistId = a1.ArtistId;
            b2.ArtistId = a2.ArtistId;
            b3.ArtistId = a3.ArtistId;

            modelBuilder.Entity<Song>(entity =>
            {
                entity.HasOne(song => song.Album)
                      .WithMany(album => album.Songs)
                      .HasForeignKey(song => song.AlbumId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Album>(entity =>
            {
                entity.HasOne(album => album.Artist)
                      .WithMany(artist => artist.Albums)
                      .HasForeignKey(album => album.ArtistId)
                      
                      .OnDelete(DeleteBehavior.Cascade);
                
            });
            modelBuilder.Entity<Artist>().HasData(
                a0,
                a1,
                a2,
                a3,
                a4);

            modelBuilder.Entity<Album>().HasData(
                b0,
                b1,
                b2,
                b3
                );

            modelBuilder.Entity<Song>().HasData(
                s0, s1, s2,
                s3, s4, s5,
                s6, s7, s8,
                s9, s10, s11);
        }
    }
}
