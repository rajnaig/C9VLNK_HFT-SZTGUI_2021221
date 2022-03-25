
using C9VLNK_HFT_2021221.Models;
using System;
using System.Linq;

namespace C9VLNK_HFT_2021221.Client
{
    public class Program
    {
        static void Main(string[] args)
        {

            System.Threading.Thread.Sleep(4000);
            RestService rest = new RestService("http://localhost:39308");

            ////ARTIST UPDATE MENU
            //#region Artist Updates Menu options
            //ConsoleMenu artistUpdates = new ConsoleMenu()
            //    .Add(" >> UPDATE ARTIST NAME", () => UpdateArtistName())
            //    .Add(" >> UPDATE ARTIST COUNTRY", () => UpdateArtistCountry())
            //    .Add(" >> UPDATE FULL ARTIST", () => UpdateFullArtist())
            //    .Add(" >> EXIT", ConsoleMenu.Close)
            //    .Configure(conf =>
            //     {
            //         conf.SelectedItemForegroundColor = ConsoleColor.Magenta;
            //         conf.SelectedItemBackgroundColor = ConsoleColor.DarkYellow;
            //         conf.Title = "artistUpdates :)";
            //         conf.Selector = "==>";
            //     });

            //#endregion

            ////ALBUM UPDATES MENU
            //#region Album Updates Menu options
            //ConsoleMenu albumUpdates = new ConsoleMenu()
            //    .Add(" >> UPDATE ALBUM TITLE", () => UpdateAlbumTitle())
            //    .Add(" >> UPDATE ALBUM RELEASE DATE", () => UpdateAlbumReleaseDate())
            //    .Add(" >> UPDATE FULL ALBUM", () => UpdateFullAlbum())
            //    .Add(" >> EXIT", ConsoleMenu.Close)
            //    .Configure(conf =>
            //    {
            //        conf.SelectedItemForegroundColor = ConsoleColor.Magenta;
            //        conf.SelectedItemBackgroundColor = ConsoleColor.DarkYellow;
            //        conf.Title = "artistUpdates :)";
            //        conf.Selector = "==>";

            //    });
            //#endregion

            ////SONG UPDATES MENU
            //#region Song Updates Menu options
            //ConsoleMenu songUpdates = new ConsoleMenu()
            //    .Add(" >> UPDATE SONG TITLE", () => UpdateSongTitle())
            //    .Add(" >> UPDATE FULL SONG", () => UpdateFullSong())
            //    .Add(" >> UPDATE SONG LENGTH", () => UpdateSongLength())
            //    .Add(" >> UPDATE SONG PRODUCER", () => UpdateSongProducer())
            //    .Add(" >> UPDATE SONG RECORDER PLAYS", () => UpdateSongPlays())
            //    .Add(" >> UPDATE SONG RELEASE DATE", () => UpdateSongReleaseDate())
            //    .Add(" >> EXIT", ConsoleMenu.Close)
            //    .Configure(conf =>

            //    {
            //        conf.SelectedItemForegroundColor = ConsoleColor.Magenta;
            //        conf.SelectedItemBackgroundColor = ConsoleColor.DarkYellow;
            //        conf.Title = "artistUpdates :)";
            //        conf.Selector = "==>";
            //    });

            //#endregion

            ////MAIN ARTIST MENU
            //#region Main Artist Menu options
            //ConsoleMenu artistMenu = new ConsoleMenu()
            //    .Add(" >> ADD ARTIST", () => AddArtist())
            //    .Add(" >> GET ARTIST", () => GetArtist())
            //    .Add(" >> GET ARTIST PLAYS", () => GetArtistPlays())
            //    .Add(" >> DELETE ARTIST", () => RemoveArtist())
            //    .Add(" >> MOST SUCCESFUL ARTIST", () => MostSuccesfulArtist())
            //    .Add(" >> LIST ARTISTS BY PLAYS", () => ListArtistsByPlays())
            //    .Add(" >> MOST FAMOUS COUNTRY BY ARTISTS COUNT", () => MostFamousCountryByArtistsCount())
            //    .Add(" >> LIST COUNTRIES BY PLAYS", () => ListCountriesByPlays())
            //    .Add(" >> AVG SONGS AMOUNT PER ARTIST", () => ArtistAvrageSongAmount())
            //    .Add(" >> GenreFilter for users", () => GenreFilter())
            //    .Add(" >> ARTIST UPDATE OPTIONS", () => artistUpdates.Show())
            //    .Add(" >> EXIT", ConsoleMenu.Close)
            //       .Configure(conf =>
            //       {
            //           conf.SelectedItemForegroundColor = ConsoleColor.Magenta;
            //           conf.SelectedItemBackgroundColor = ConsoleColor.DarkYellow;
            //           conf.Selector = "==>";
            //       });
            //#endregion

            ////MAIN ALBUM MENU
            //#region Main Album Menu options
            //ConsoleMenu albumMenu = new ConsoleMenu()
            //   .Add(" >> ADD ALBUM", () => AddAlbum())
            //   .Add(" >> GET ALBUM", () => GetAlbum())
            //   .Add(" >> GET ALBUM PLAYS", () => GetAlbumPlays())
            //   .Add(" >> ALBUM UPDATE OPTIONS", () => albumUpdates.Show())
            //   .Add(" >> DELETE ALBUM", () => DeleteAlbum())
            //   .Add(" >> MOST PLAYED ALBUM", () => AlbumWithTheMostPlays())
            //   .Add(" >> LIST ALBUM BY PLAYS", () => AlbumsOrderedByPlays())
            //   .Add(" >> LIST ALBUMS BY RELEASE DATE", () => AlbumsOrderedByReleaseDate())
            //   .Add(" >> EXIT", ConsoleMenu.Close)
            //      .Configure(conf =>
            //      {
            //          conf.SelectedItemForegroundColor = ConsoleColor.Magenta;
            //          conf.SelectedItemBackgroundColor = ConsoleColor.DarkYellow;
            //          conf.Selector = "==>";
            //      });
            //#endregion

            ////MAIN SONG MENU
            //#region Main Song Menu options
            //ConsoleMenu songMenu = new ConsoleMenu()
            //  .Add(" >> ADD SONG", () => AddSong())
            //  .Add(" >> GET SONG", () => GetSong())
            //  .Add(" >> GET ALBUM PLAYS", () => GetSongPlays())
            //  .Add(" >> ALL THE GENRES IN THE DATABASE", () => GetGenres())
            //  .Add(" >> SONG UPDATE MENU", () => songUpdates.Show())
            //  .Add(" >> MOST PLAYED GENRE(SONG)", () => MostPlayedGenre())
            //  .Add(" >> DELETE SONG", () => DeleteSong())
            //  .Add(" >> LIST GENRES by=>PLAYS", () => GenresOrderedByPlays())
            //  .Add(" >> ALL THE PLAYS RECORDED IN THE DATABASE", () => PlaysInDatabase())
            //  .Add(" >> EXIT", ConsoleMenu.Close)
            //      .Configure(conf =>
            //      {
            //          conf.SelectedItemForegroundColor = ConsoleColor.Magenta;
            //          conf.SelectedItemBackgroundColor = ConsoleColor.DarkYellow;
            //          conf.Title = "Music DataBase :)";
            //          conf.Selector = "==>";

            //      });
            //#endregion

            ////MAIN MENU
            //#region Main Menu
            //ConsoleMenu menu = new ConsoleMenu()
            //    .Add(" >> LIST ALL ARTIST", () => ListAllArtists())
            //    .Add(" >> LIST ALL ALBUMS", () => ListAllAlbums())
            //    .Add(" >> LIST ALL SONGS", () => ListAllSongs())
            //    .Add(" >> ARTIST MENU", () => artistMenu.Show())
            //    .Add(" >> ALBUM MENU", () => albumMenu.Show())
            //    .Add(" >> SONG MENU", () => songMenu.Show())
            //    .Add(" >> EXIT", ConsoleMenu.Close)
            //    .Configure(conf =>
            //    {
            //        conf.SelectedItemForegroundColor = ConsoleColor.Magenta;
            //        conf.SelectedItemBackgroundColor = ConsoleColor.DarkYellow;
            //        conf.Title = "Music DataBase :)";
            //        conf.Selector = "==>";

            //    });
            //menu.Show();
            //#endregion

            //LIST ALL
            #region "List all" methods for the menu structure
            void ListAllArtists()
            {

                ConsoleKeyInfo input = new ConsoleKeyInfo();
                var artists = rest.Get<Artist>("artist");
                while (input.Key != ConsoleKey.Y)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    foreach (var item in artists)
                    {
                        //Console.WriteLine($" {item.AllData}");
                    }
                    Console.WriteLine();
                    Console.Write(" Do you want to go back to the menu?  ");
                    ColorWrite(false, ConsoleColor.Blue, '(');
                    ColorWrite(false, ConsoleColor.Green, 'Y');
                    ColorWrite(false, ConsoleColor.Blue, '/');
                    ColorWrite(false, ConsoleColor.Red, 'N');
                    ColorWrite(false, ConsoleColor.Blue, ')');


                    BoxMakerByGabi(0, 0, artists.Count() + 4 * 2, 60, ConsoleColor.Yellow, ConsoleColor.Yellow, 'o', '|', '-');

                    input = Console.ReadKey();


                    if (input.Key != ConsoleKey.Y)
                    {
                        Console.Clear();
                    }
                }
            }
            void ListAllAlbums()
            {
                ConsoleKeyInfo input = new ConsoleKeyInfo();
                var albums = rest.Get<Album>("album");
                while (input.Key != ConsoleKey.Y)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    foreach (var album in albums)
                    {
                        Console.WriteLine($" [{album.AlbumId}]. {album.AlbumTitle}");
                    }
                    Console.WriteLine();
                    Console.Write(" Do you want to go back to the menu?  ");
                    ColorWrite(false, ConsoleColor.Blue, '(');
                    ColorWrite(false, ConsoleColor.Green, 'Y');
                    ColorWrite(false, ConsoleColor.Blue, '/');
                    ColorWrite(false, ConsoleColor.Red, 'N');
                    ColorWrite(false, ConsoleColor.Blue, ')');


                    BoxMakerByGabi(0, 0, albums.Count() + 4 * 2, 50, ConsoleColor.Yellow, ConsoleColor.Yellow, 'o', '|', '-');

                    input = Console.ReadKey();


                    if (input.Key != ConsoleKey.Y)
                    {
                        Console.Clear();
                    }
                }
            }
            void ListAllSongs()
            {
                ConsoleKeyInfo input = new ConsoleKeyInfo();
                var songs = rest.Get<Song>("song");
                while (input.Key != ConsoleKey.Y)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    foreach (var song in songs)
                    {
                        Console.WriteLine($" [{song.SongId}]. {song.Title}");
                    }
                    Console.WriteLine();
                    Console.Write(" Do you want to go back to the menu?  ");
                    ColorWrite(false, ConsoleColor.Blue, '(');
                    ColorWrite(false, ConsoleColor.Green, 'Y');
                    ColorWrite(false, ConsoleColor.Blue, '/');
                    ColorWrite(false, ConsoleColor.Red, 'N');
                    ColorWrite(false, ConsoleColor.Blue, ')');


                    BoxMakerByGabi(0, 0, songs.Count() + 4 * 2, 50, ConsoleColor.Yellow, ConsoleColor.Yellow, 'o', '|', '-');

                    input = Console.ReadKey();


                    if (input.Key != ConsoleKey.Y)
                    {
                        Console.Clear();
                    }
                }
            }
            #endregion

            //ARTIST
            #region Artist method calls for the menu structure
            // ARTIST 
            void AddArtist()
            {
                var artist = new Artist();
                Console.WriteLine("Add a new artist to the DataBase!");
                Console.WriteLine();
                Console.Write("Name:");
                artist.Name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Artist's Country:");
                artist.Country = Console.ReadLine();

                Console.Write("Artist's Genre:");
                artist.ArtistGenre = (Genres)Enum.Parse(typeof(Genres), Console.ReadLine());

                rest.Post<Artist>(artist, "artist");

                Console.WriteLine("Artist succesfully has been added!");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();


            }
            void RemoveArtist()
            {
                Console.WriteLine("Delete an Artist from the DataBase!");
                Console.WriteLine("");
                Console.WriteLine("Type in an Artist ID That you want to delete:  ");
                int id = int.Parse(Console.ReadLine());
                Artist artist = new Artist();
                try
                {
                    artist = rest.Get<Artist>(id, "artist");
                    if (artist == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        rest.Delete(id, "artist");

                        Console.WriteLine("Artist succesfully has been deleted from the database!");
                        System.Threading.Thread.Sleep(2000);
                        Console.ReadLine();
                        Console.Clear();
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("No Artist found with the given ID in the DataBase");
                }


            }
            void GetArtist()
            {
                Console.WriteLine("Get an Artist from the DataBase!");
                Console.WriteLine("");
                Console.WriteLine("Type in an Artist ID That you want to get:  ");
                int id = int.Parse(Console.ReadLine());

                var artist = new Artist();
                try
                {
                    artist = rest.Get<Artist>(id, "artist");

                    if (artist == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("Artist has been found succesfully");
                        Console.WriteLine();
                        ColorWrite(false, ConsoleColor.Green, "Artist's ID: ");
                        Console.WriteLine(artist.ArtistId);
                        ColorWrite(false, ConsoleColor.Green, "Artist's Name: ");
                        Console.WriteLine(artist.Name);
                        ColorWrite(false, ConsoleColor.Green, "Artist's Genre: ");
                        Console.WriteLine(artist.ArtistGenre);

                        ColorWrite(true, ConsoleColor.White, "Artist albums and songs:");
                        foreach (var album in rest.Get<Album>("album").Where(x => x.ArtisId == artist.ArtistId))
                        {
                            ColorWrite(false, ConsoleColor.Green, "\n\tAlbum Title:\t");
                            Console.WriteLine(album.AlbumTitle);
                            Console.WriteLine();
                            foreach (var song in rest.Get<Song>("song").Where(x => x.AlbumId == album.AlbumId))
                            {
                                ColorWrite(false, ConsoleColor.Green, "\tSong Title:\t");
                                Console.WriteLine(song.Title);
                            }
                            Console.WriteLine();
                        }


                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There is no artist in the Database with the given ID");

                    Console.WriteLine("Go back to the Menu!");
                    System.Threading.Thread.Sleep(1000);
                }
            }
            void GetArtistPlays()
            {


                Console.WriteLine("Get An artist plays from the database!");
                Console.WriteLine("Please write in an Artist ID:");
                int id = int.Parse(Console.ReadLine());


                var artist = new Artist();
                try
                {
                    artist = rest.Get<Artist>(id, "artist");

                    if (artist == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("The given ID is correct!");

                        var plays = rest.GetSingle<int>($"stat/getplays/{artist.ArtistId}");
                        Console.WriteLine();
                        Console.Write("Searcing");

                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write('.');
                            System.Threading.Thread.Sleep(500);
                        }
                        Console.WriteLine();
                        Console.WriteLine($"{artist.Name}'s recorded plays: {plays}");
                        Console.ReadLine();
                        Console.Clear();

                    }


                }
                catch (Exception)
                {

                    Console.WriteLine("No Artist foound in the Database With the given ID..");
                }
            }
            void ListArtistsByPlays()
            {
                Console.Clear();
                var list = rest.Get<ArtistByPlays>("stat/listartistsbyplays");


                foreach (var artist in list)
                {

                    ColorWrite(false, ConsoleColor.White, $"\n  Id:[{artist.ArtistId}]. Name:{artist.ArtistName} ");
                    ColorWrite(false, ConsoleColor.Green, $"{artist.Plays} plays");
                    Console.WriteLine();
                }
                BoxMakerByGabi(0, 0, list.Count() + 3 * 2, 50, ConsoleColor.Yellow, ConsoleColor.Yellow, 'o', '|', '-');
                Console.ReadLine();
                Console.Clear();
            }
            void MostSuccesfulArtist()
            {
                Artist artist = new Artist();
                try
                {
                    artist = rest.GetSingle<Artist>("stat/mostsuccessfulartist");
                    if (artist == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("Artist has been found succesfully");
                        Console.WriteLine();
                        ColorWrite(false, ConsoleColor.Green, "Artist's ID: ");
                        Console.WriteLine(artist.ArtistId);
                        ColorWrite(false, ConsoleColor.Green, "Artist's Name: ");
                        Console.WriteLine(artist.Name);
                        ColorWrite(false, ConsoleColor.Green, "Artist's Genre: ");
                        Console.WriteLine(artist.ArtistGenre);
                        ColorWrite(false, ConsoleColor.Green, "Artist's Country: ");
                        Console.WriteLine(artist.Country);

                        ColorWrite(true, ConsoleColor.White, "Artist albums and songs:");
                        foreach (var album in rest.Get<Album>("album").Where(x => x.ArtisId == artist.ArtistId))
                        {
                            ColorWrite(false, ConsoleColor.Green, "\n\tAlbum Title:\t");
                            Console.WriteLine(album.AlbumTitle);
                            Console.WriteLine();
                            foreach (var song in rest.Get<Song>("song").Where(x => x.AlbumId == album.AlbumId))
                            {
                                ColorWrite(false, ConsoleColor.Green, "\tSong Title:\t");
                                Console.WriteLine(song.Title);
                            }
                            Console.WriteLine();
                        }


                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("No Artist found in the Database!");
                }
            }
            void ListCountriesByPlays()
            {
                Console.Clear();
                var list = rest.Get<CountriesByPlays>("stat/listcountriesbyplays");


                foreach (var country in list)
                {

                    ColorWrite(false, ConsoleColor.White, $"\n  Country:[{country.CountryName}]. Plays:{country.Plays} ");
                    Console.WriteLine();
                }
                BoxMakerByGabi(0, 0, list.Count() + 3 * 2, 50, ConsoleColor.Yellow, ConsoleColor.Yellow, 'o', '|', '-');
                Console.ReadLine();
                Console.Clear();
            }
            void MostFamousCountryByArtistsCount()
            {
                string country = "";
                try
                {

                    country = rest.GetSingle<string>("artist/mostfamouscountrybyartistscount");
                    if (country == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("The most famous country by the numbers of registered artists in the country");
                        Console.WriteLine();
                        Console.WriteLine(country);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("No Data found in the Database!");
                }

            }
            void UpdateArtistName()
            {

                Console.WriteLine("Type in an ID to change an artist name!");
                int id = int.Parse(Console.ReadLine());
                Artist artist = new Artist();
                try
                {
                    artist = rest.Get<Artist>(id, "artist");
                    if (artist == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("Artist succesfully found in the database!");
                        Console.WriteLine();
                        Console.WriteLine("Artist current name: " + artist.Name);
                        Console.WriteLine("Type in a new Name and the program going to change it!");
                        Console.WriteLine("New Name: ");
                        string newName = Console.ReadLine();
                        Console.WriteLine();


                        rest.PutProperty<string>(ControllerType.artist, MethodRootTpye.updatename, id, newName);

                        Console.WriteLine("Change Happened succesfully");
                        System.Threading.Thread.Sleep(1000);
                        Console.ReadLine();
                        Console.Clear();


                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("No Data found in the Database!");
                    System.Threading.Thread.Sleep(2000);
                    Console.ReadLine();
                    Console.Clear();
                }

                //[Route("updatename/{id}/{newName}")]
                //[HttpPut("{id} {newName}")]
                //public void UpdateName(int id, string newName)
                //{
                //    artistLogic.UpdateArtistName(id, newName);
                //}

            }
            void UpdateArtistCountry()
            {

                Console.WriteLine("Type in an ID to change an artist country!");
                int id = int.Parse(Console.ReadLine());
                Artist artist = new Artist();
                try
                {
                    artist = rest.Get<Artist>(id, "artist");
                    if (artist == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("Artist succesfully found in the database!");
                        Console.WriteLine();
                        Console.WriteLine("Artist current country: " + artist.Country);
                        Console.WriteLine("Type in a new country and the program going to change it!");
                        Console.WriteLine("New Country: ");
                        string newCountry = Console.ReadLine();
                        Console.WriteLine();


                        rest.PutProperty<string>(ControllerType.artist, MethodRootTpye.updatecountry, id, newCountry);

                        Console.WriteLine("Change Happened succesfully");
                        System.Threading.Thread.Sleep(1000);
                        Console.ReadLine();
                        Console.Clear();


                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("No Data found in the Database!");
                    System.Threading.Thread.Sleep(2000);
                    Console.ReadLine();
                    Console.Clear();
                }

                //[Route("updatename/{id}/{newName}")]
                //[HttpPut("{id} {newName}")]
                //public void UpdateName(int id, string newName)
                //{
                //    artistLogic.UpdateArtistName(id, newName);
                //}

            }
            void UpdateFullArtist()
            {
                var newArtist = new Artist();
                Console.WriteLine("Update Full Menu");

                Console.WriteLine("Type in artist's ID: ");
                newArtist.ArtistId = int.Parse(Console.ReadLine());

                Console.WriteLine("Type in artist's name: ");
                newArtist.Name = Console.ReadLine();

                Console.WriteLine("Type in artist's Nationality/Country: ");
                newArtist.Country = Console.ReadLine();

                Console.WriteLine("Type in artist's Genre: ");
                newArtist.ArtistGenre = (Genres)Enum.Parse(typeof(Genres), Console.ReadLine());

                rest.Put<Artist>(newArtist, "artist");

                Console.WriteLine("Succesfully Updated");

            }
            void ArtistAvrageSongAmount()
            {
                var list = rest.Get<AvarageSongAmountPerArtist>("stat/ArtistAvrageSongAmount");
                foreach (var artistsongs in list)
                {
                    Console.WriteLine(artistsongs.ToString());
                }
                Console.ReadLine();
                Console.Clear();
            }
            void GenreFilter()
            {

                Console.WriteLine("Type in a Genre Type");
                Genres genre = (Genres)Enum.Parse(typeof(Genres), Console.ReadLine());
                var data = rest.Get<ArtistAndSelectedGenreSongs>($"stat/genrefilter/{genre}");

                foreach (var Artist in data)
                {
                    Console.WriteLine($"ArtistID: {Artist.ArtistId}");
                    Console.WriteLine($"Artist Name: {Artist.ArtistName}\n");
                    foreach (var song in Artist.FilteredSongs)
                    {
                        Console.WriteLine($"\tSongs Title:{song.Title}\n");
                    }
                }
                Console.ReadLine();
                Console.Clear();
            }
            #endregion

            //ALBUMS
            #region Album method calls for the menu structure
            void AddAlbum()
            {
                var album = new Album();
                Console.WriteLine("Add a new Album to the DataBase!");
                Console.WriteLine();
                Console.Write("Title:");
                album.AlbumTitle = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Album's Artist ID: ");
                album.ArtisId = int.Parse(Console.ReadLine());

                Console.Write("Album's Release Date:");
                album.ReleaseDate = DateTime.Parse(Console.ReadLine());

                rest.Post<Album>(album, "album");

                Console.WriteLine("Album succesfully has been added!");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
            }
            void GetAlbum()
            {
                Console.WriteLine("Get an Album from the DataBase!");
                Console.WriteLine("");
                Console.WriteLine("Type in an Album's ID that you want to get:  ");
                int id = int.Parse(Console.ReadLine());

                var album = new Album();
                try
                {
                    album = rest.Get<Album>(id, "album");

                    if (album == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("Album has been found succesfully");
                        Console.WriteLine();
                        ColorWrite(false, ConsoleColor.Green, "Album's ID: ");
                        Console.WriteLine(album.AlbumId);
                        ColorWrite(false, ConsoleColor.Green, "Album's Title: ");
                        Console.WriteLine(album.AlbumTitle);
                        ColorWrite(false, ConsoleColor.Green, "Album's Release Date: ");
                        Console.WriteLine(album.ReleaseDate);

                        ColorWrite(true, ConsoleColor.White, "Album's songs:");
                        foreach (var song in album.Songs)
                        {
                            ColorWrite(false, ConsoleColor.Green, "\tSong Title:\t");
                            Console.WriteLine(song.Title);

                        }


                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There is no album in the Database with the given ID");

                    Console.WriteLine("Go back to the Menu!");
                    System.Threading.Thread.Sleep(1000);
                }
            }
            void GetAlbumPlays()
            {
                Console.WriteLine("Get An Album plays from the database!");
                Console.WriteLine("Please write in an Album ID:");
                int id = int.Parse(Console.ReadLine());


                var album = new Album();
                try
                {
                    album = rest.Get<Album>(id, "album");

                    if (album == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("The given ID is correct!");

                        var plays = rest.GetSingle<int>($"stat/getalbumplays/{album.AlbumId}");
                        Console.WriteLine();
                        Console.Write("Searcing");

                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write('.');
                            System.Threading.Thread.Sleep(500);
                        }
                        Console.WriteLine();
                        Console.WriteLine($"{album.AlbumTitle}'s recorded plays: {plays}");
                        Console.ReadLine();
                        Console.Clear();

                    }


                }
                catch (Exception)
                {

                    Console.WriteLine("No Album found in the Database with the given ID..");
                }
            }
            void UpdateAlbumTitle()
            {
                Console.WriteLine("Type in an ID to change an Album name!");
                int id = int.Parse(Console.ReadLine());
                Album album = new Album();
                try
                {
                    album = rest.Get<Album>(id, "album");
                    if (album == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("Album succesfully found in the database!");
                        Console.WriteLine();
                        Console.WriteLine("Album's current name: " + album.AlbumTitle);
                        Console.WriteLine("Type in a new Title and the program going to change it!");
                        Console.WriteLine("New Title: ");
                        string newTitle = Console.ReadLine();
                        Console.WriteLine();


                        rest.PutProperty<string>(ControllerType.album, MethodRootTpye.updatetitle, id, newTitle);

                        Console.WriteLine("Change Happened succesfully");
                        System.Threading.Thread.Sleep(1000);
                        Console.ReadLine();
                        Console.Clear();


                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("No Data found in the Database!");
                    System.Threading.Thread.Sleep(2000);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            void UpdateAlbumReleaseDate()
            {
                Console.WriteLine("Type in an ID to change an Album release date!");
                int id = int.Parse(Console.ReadLine());
                Album album = new Album();
                try
                {
                    album = rest.Get<Album>(id, "album");
                    if (album == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("Album succesfully found in the database!");
                        Console.WriteLine();
                        Console.WriteLine("Album's current Release Date: " + album.ReleaseDate);
                        Console.WriteLine("Type in a new Release Date and the program going to change it!");
                        Console.WriteLine("New Release Date: ");
                        string newReleaseDate = Console.ReadLine();
                        Console.WriteLine();


                        rest.PutProperty<string>(ControllerType.album, MethodRootTpye.updatealbumreleasedate, id, newReleaseDate);

                        Console.WriteLine("Change Happened succesfully");
                        System.Threading.Thread.Sleep(1000);
                        Console.ReadLine();
                        Console.Clear();


                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("No Data found in the Database!");
                    System.Threading.Thread.Sleep(2000);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            void UpdateFullAlbum()
            {
                var newAlbum = new Album();
                Console.WriteLine("Update Full Album Menu");

                Console.WriteLine("Type in Album's ID: ");
                newAlbum.AlbumId = int.Parse(Console.ReadLine());


                Console.WriteLine("Type in the Album Artist ID:");
                newAlbum.ArtisId = int.Parse(Console.ReadLine());


                Console.WriteLine("Type in Album's name: ");
                newAlbum.AlbumTitle = Console.ReadLine();

                Console.WriteLine("Type in album's release date:");
                newAlbum.ReleaseDate = DateTime.Parse(Console.ReadLine());


                rest.Put<Album>(newAlbum, "album");

                Console.WriteLine("Succesfully Updated");
            }
            void DeleteAlbum()
            {
                Console.WriteLine("Delete an Album from the DataBase!");
                Console.WriteLine("");
                Console.WriteLine("Type in an Album ID That you want to delete:  ");
                int id = int.Parse(Console.ReadLine());
                Album album = new Album();
                try
                {
                    album = rest.Get<Album>(id, "album");
                    if (album == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        rest.Delete(id, "album");

                        Console.WriteLine("Album succesfully has been deleted from the database!");
                        System.Threading.Thread.Sleep(2000);
                        Console.ReadLine();
                        Console.Clear();
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("No Album found with the given ID in the DataBase");
                }

            }
            void AlbumWithTheMostPlays()
            {
                Album album = new Album();
                try
                {
                    album = rest.GetSingle<Album>("stat/albumwiththemostplays");
                    if (album == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("Album has been found succesfully");
                        Console.WriteLine();
                        ColorWrite(false, ConsoleColor.Green, "Album's ID: ");
                        Console.WriteLine(album.AlbumId);
                        ColorWrite(false, ConsoleColor.Green, "Album's Title: ");
                        Console.WriteLine(album.AlbumTitle);
                        ColorWrite(false, ConsoleColor.Green, "Album's Release Date: ");
                        Console.WriteLine(album.ReleaseDate);

                        ColorWrite(true, ConsoleColor.White, "Album's songs:");
                        foreach (var song in album.Songs)
                        {
                            ColorWrite(false, ConsoleColor.Green, "\tSong Title:\t");
                            Console.WriteLine(song.Title);

                        }


                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("No Album found in the Database!");
                }
            }
            void AlbumsOrderedByPlays()
            {
                var list = rest.Get<AlbumByPlays>("stat/albumsorderedbyplays");

                foreach (var album in list)
                {
                    Console.WriteLine(album.ToString());
                }

                Console.ReadLine();
                Console.Clear();
            }
            void AlbumsOrderedByReleaseDate()
            {
                var list = rest.Get<Album>("stat/albumsorderedbyreleasedate");

                foreach (var album in list)
                {
                    Console.WriteLine(album.ToString());
                }

                Console.ReadLine();
                Console.Clear();
            }
            #endregion

            //SONGS 
            #region Song method calls for the menu structure

            void AddSong()
            {
                var song = new Song();
                Console.WriteLine("Add a new Song to the DataBase!");
                Console.WriteLine();
                Console.Write("Title:");
                song.Title = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Song's Album ID: ");
                song.AlbumId = int.Parse(Console.ReadLine());

                Console.Write("Song's Release Date:");
                song.ReleaseDate = DateTime.Parse(Console.ReadLine());

                rest.Post<Song>(song, "song");

                Console.WriteLine("Song succesfully has been added!");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
            }
            void GetSong()
            {
                Console.WriteLine("Get an Song from the DataBase!");
                Console.WriteLine("");
                Console.WriteLine("Type in an Song's ID that you want to get:  ");
                int id = int.Parse(Console.ReadLine());

                var song = new Song();
                try
                {
                    song = rest.Get<Song>(id, "song");

                    if (song == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("Song has been found succesfully");
                        Console.WriteLine();
                        ColorWrite(false, ConsoleColor.Green, "Song's ID: ");
                        Console.WriteLine(song.AlbumId);
                        ColorWrite(false, ConsoleColor.Green, "Song's Title: ");
                        Console.WriteLine(song.Title);
                        ColorWrite(false, ConsoleColor.Green, "Song's Release Date: ");
                        Console.WriteLine(song.ReleaseDate);
                        ColorWrite(false, ConsoleColor.Green, "Song's recorded plays data: ");
                        Console.WriteLine(song.Plays);
                        ColorWrite(false, ConsoleColor.Green, "Song's Producer: ");
                        Console.WriteLine(song.Producer);


                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("There is no song in the Database with the given ID");

                    Console.WriteLine("Go back to the Menu!");
                    System.Threading.Thread.Sleep(1000);
                }
            }
            void GetSongPlays()
            {
                Console.WriteLine("Get An Song plays from the database!");
                Console.WriteLine("Please write in an Song ID:");
                int id = int.Parse(Console.ReadLine());


                var song = new Song();
                try
                {
                    song = rest.Get<Song>(id, "song");

                    if (song == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("The given ID is correct!");

                        var plays = rest.GetSingle<int>($"stat/getsongplays/{id}");
                        Console.WriteLine();
                        Console.Write("Searcing");

                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write('.');
                            System.Threading.Thread.Sleep(500);
                        }
                        Console.WriteLine();
                        Console.WriteLine($"{song.Title}'s recorded plays: {plays}");
                        Console.ReadLine();
                        Console.Clear();

                    }


                }
                catch (Exception)
                {

                    Console.WriteLine("No Song found in the Database with the given ID..");
                }
            }
            void GetGenres()
            {
                var genres = rest.Get<Genres>("stat/GetGenres");
                Console.WriteLine("All the genres in the database");
                foreach (var genre in genres)
                {
                    Console.WriteLine(genre);
                }
                Console.ReadLine();
                Console.Clear();
            }
            void UpdateSongTitle()
            {
                Console.WriteLine("Type in an ID to change an Song name!");
                int id = int.Parse(Console.ReadLine());
                Song song = new Song();
                try
                {
                    song = rest.Get<Song>(id, "song");
                    if (song == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("Song succesfully found in the database!");
                        Console.WriteLine();
                        Console.WriteLine("Song's current title: " + song.Title);
                        Console.WriteLine("Type in a new Title and the program going to change it!");
                        Console.WriteLine("New Title: ");
                        string newTitle = Console.ReadLine();
                        Console.WriteLine();


                        rest.PutProperty<string>(ControllerType.song, MethodRootTpye.updateStitle, id, newTitle);

                        Console.WriteLine("Change Happened succesfully");
                        System.Threading.Thread.Sleep(1000);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("No Data found in the Database!");
                    System.Threading.Thread.Sleep(2000);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            void UpdateSongLength()
            {
                Console.WriteLine("Type in an ID to change an Song Length!");
                int id = int.Parse(Console.ReadLine());
                Song song = new Song();
                try
                {
                    song = rest.Get<Song>(id, "song");
                    if (song == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("Song succesfully found in the database!");
                        Console.WriteLine();
                        Console.WriteLine("Song's current ID: " + song.SongId);
                        Console.WriteLine("Song's current Title: " + song.Title);
                        Console.WriteLine("Song's current lenght: " + song.Length);

                        Console.WriteLine("Type in a new Lenght and the program going to change it!");
                        Console.WriteLine("New Lenght: ");
                        TimeSpan newLenght = TimeSpan.Parse(Console.ReadLine());
                        Console.WriteLine();


                        rest.PutProperty<TimeSpan>(ControllerType.song, MethodRootTpye.updatesonglength, id, newLenght);

                        Console.WriteLine("Change Happened succesfully");
                        System.Threading.Thread.Sleep(1000);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("No Data found in the Database!");
                    System.Threading.Thread.Sleep(2000);
                    Console.ReadLine();
                    Console.Clear();
                }

            }
            void UpdateSongPlays()
            {
                Console.WriteLine("Type in an ID to change an Song recorder plays data!");
                int id = int.Parse(Console.ReadLine());
                Song song = new Song();
                try
                {
                    song = rest.Get<Song>(id, "song");
                    if (song == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("Song succesfully found in the database!");
                        Console.WriteLine();
                        Console.WriteLine("Song's current ID: " + song.SongId);
                        Console.WriteLine("Song's current Title: " + song.Title);
                        Console.WriteLine("Song's current lenght: " + song.Length);
                        Console.WriteLine("Song's current plays: " + song.Plays);

                        Console.WriteLine("Type in a new Plays and the program going to change it!");
                        Console.WriteLine("New Plays: ");
                        int newPlays = int.Parse(Console.ReadLine());
                        Console.WriteLine();


                        rest.PutProperty<int>(ControllerType.song, MethodRootTpye.updatesongplays, id, newPlays);

                        Console.WriteLine("Change Happened succesfully");
                        System.Threading.Thread.Sleep(1000);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("No Data found in the Database!");
                    System.Threading.Thread.Sleep(2000);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            void UpdateFullSong()
            {
                var newSong = new Song();
                Console.WriteLine("Update Full Song Menu");

                Console.WriteLine("Type in Song's ID: ");

                newSong.SongId = int.Parse(Console.ReadLine());


                var oldSong = rest.Get<Song>(newSong.SongId, "song");


                Console.WriteLine("Song has been found succesfully");
                Console.WriteLine();
                ColorWrite(false, ConsoleColor.Green, "Song's ID: ");
                Console.WriteLine(oldSong.SongId);

                ColorWrite(false, ConsoleColor.Green, "Song's  ALBUM ID: ");
                Console.WriteLine(oldSong.AlbumId);

                ColorWrite(false, ConsoleColor.Green, "Song's Title: ");
                Console.WriteLine(oldSong.Title);
                ColorWrite(false, ConsoleColor.Green, "Song's Release Date: ");
                Console.WriteLine(oldSong.ReleaseDate);
                ColorWrite(false, ConsoleColor.Green, "Song's recorded plays data: ");
                Console.WriteLine(oldSong.Plays);
                ColorWrite(false, ConsoleColor.Green, "Song's Producer: ");
                Console.WriteLine(oldSong.Producer);




                Console.WriteLine("TYPE IN NEW DATAS");
                Console.WriteLine("\n\n");
                Console.WriteLine("Type in the Song Album's ID:");
                newSong.AlbumId = int.Parse(Console.ReadLine());


                Console.WriteLine("Type in Song's Title: ");
                newSong.Title = Console.ReadLine();

                Console.WriteLine("Type in Song's release date:");
                newSong.ReleaseDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Type in Song's Procuder:");
                newSong.Producer = Console.ReadLine();


                Console.WriteLine("Type in Song's Plays:");
                newSong.Plays = int.Parse(Console.ReadLine());

                rest.Put<Song>(newSong, "song");

                Console.WriteLine("Song Succesfully Updated++++!!!");
            }
            void UpdateSongReleaseDate()
            {
                Console.WriteLine("Type in an ID to change an Song release date!");
                int id = int.Parse(Console.ReadLine());
                Song song = new Song();
                try
                {
                    song = rest.Get<Song>(id, "song");
                    if (song == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("Song succesfully found in the database!");
                        Console.WriteLine();
                        Console.WriteLine("Song's current Release Date: " + song.ReleaseDate);
                        Console.WriteLine("Type in a new Release Date and the program going to change it!");
                        Console.WriteLine("New Release Date: ");
                        string newReleaseDate = Console.ReadLine();
                        Console.WriteLine();


                        rest.PutProperty<string>(ControllerType.song, MethodRootTpye.updatesongreleasedate, id, newReleaseDate);

                        Console.WriteLine("Change Happened succesfully");
                        System.Threading.Thread.Sleep(1000);
                        Console.ReadLine();
                        Console.Clear();


                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("No Data found in the Database!");
                    System.Threading.Thread.Sleep(2000);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            void UpdateSongProducer()
            {
                Console.WriteLine("Type in an ID to change an Song's Producer!");
                int id = int.Parse(Console.ReadLine());
                Song song = new Song();
                try
                {
                    song = rest.Get<Song>(id, "song");
                    if (song == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Console.WriteLine("Song succesfully found in the database!");
                        Console.WriteLine();
                        Console.WriteLine("Song's current Producer: " + song.Producer);
                        Console.WriteLine("Type in a Producer's Name and the program going to change it!");
                        Console.WriteLine("New Producer: ");
                        string newProducer = Console.ReadLine();
                        Console.WriteLine();


                        rest.PutProperty<string>(ControllerType.song, MethodRootTpye.updatesongproducer, id, newProducer);

                        Console.WriteLine("Change Happened succesfully");
                        System.Threading.Thread.Sleep(1000);
                        Console.ReadLine();
                        Console.Clear();


                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("No Data found in the Database!");
                    System.Threading.Thread.Sleep(2000);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            void DeleteSong()
            {
                Console.WriteLine("Delete an Song from the DataBase!");
                Console.WriteLine("");
                Console.WriteLine("Type in an Song ID That you want to delete:  ");
                int id = int.Parse(Console.ReadLine());
                Song song = new Song();
                try
                {
                    song = rest.Get<Song>(id, "song");
                    if (song == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        rest.Delete(id, "song");

                        Console.WriteLine("Song succesfully has been deleted from the database!");
                        System.Threading.Thread.Sleep(2000);
                        Console.ReadLine();
                        Console.Clear();
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("No Song found with the given ID in the DataBase");
                }

            }
            void MostPlayedGenre()
            {

                var genre = rest.GetSingle<PlaysByGenres>("stat/mostplayedgenre");

                Console.WriteLine("MOST PLAYED GENRE AND ITS PLAYS");
                Console.WriteLine("\n\n");
                Console.WriteLine(genre.ToString());
                Console.ReadLine();
                Console.Clear();
            }
            void GenresOrderedByPlays()
            {
                var ordereList = rest.Get<PlaysByGenres>("stat/genresorderedbyplays");
                foreach (var genres in ordereList)
                {
                    Console.WriteLine(genres.ToString());
                    Console.WriteLine("\n");
                }
                Console.ReadLine();
                Console.Clear();
            }
            void PlaysInDatabase()
            {
                var allThePlays = rest.GetSingle<int>("stat/playsintheDatabase");
                Console.WriteLine("All the recorder plays in the database");

                Console.WriteLine(allThePlays);
                Console.ReadLine();
                Console.Clear();

            }

            #endregion

            //VISUAL METHODS
            #region Visual helper methods

            void ColorWrite(bool mode, ConsoleColor color, object content)
            {
                Console.ForegroundColor = color;
                if (mode)
                {

                    Console.WriteLine(content);
                }
                else
                {
                    Console.Write(content);
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            void BoxMakerByGabi(int x, int y, int height, int width, ConsoleColor cornercolor, ConsoleColor linescolor, char sarok, char keret, char teto)
            {
                BoxHelper(x, y, sarok, cornercolor);
                BoxHelper(x + width - 1, y, sarok, cornercolor);
                BoxHelper(x, y + height - 1, sarok, cornercolor);
                BoxHelper(x + width - 1, y + height - 1, sarok, cornercolor);

                for (int i = 0; i < width - 2; i++)
                {
                    BoxHelper(x + 1 + i, y, teto, linescolor);
                    BoxHelper(x + 1 + i, y + height - 1, teto, linescolor);
                }
                for (int i = 0; i < height - 2; i++)
                {
                    BoxHelper(x, y + 1 + i, keret, linescolor);
                    BoxHelper(x + width - 1, y + 1 + i, keret, linescolor);
                }
            }
            void BoxHelper(int x, int y, char z, ConsoleColor color)
            {
                Console.ForegroundColor = color;
                Console.SetCursorPosition(x, y);
                Console.Write(z);
            }
            #endregion


        }
    }
}
