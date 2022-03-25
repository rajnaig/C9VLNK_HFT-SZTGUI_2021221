namespace C9VLNK_HFT_2021221.Models
{
    public class ArtistByPlays
    {
        public string ArtistName { get; set; }
        public int ArtistId { get; set; }
        public int Plays { get; set; }
        public override string ToString()
        {
            return $"{ArtistId} - {ArtistName}  {Plays}";
        }
    }
}
