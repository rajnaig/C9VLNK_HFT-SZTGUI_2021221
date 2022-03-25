using System.Collections.Generic;

namespace C9VLNK_HFT_2021221.Models
{
    public class ArtistAndSelectedGenreSongs
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public ICollection<Song> FilteredSongs { get; set; }
    }
}
