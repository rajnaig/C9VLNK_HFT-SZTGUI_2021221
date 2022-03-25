namespace C9VLNK_HFT_2021221.Models
{
    public class AvarageSongAmountPerArtist
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public double AverageAmount { get; set; }
        public override string ToString()
        {
            return $"ArtistID:{ArtistId} \n" +
                $"Artist's Name:{ArtistName} \n" +
                $"Average Song Amount => |{AverageAmount}|\n";
        }
    }
}
