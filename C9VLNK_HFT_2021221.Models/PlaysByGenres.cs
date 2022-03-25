namespace C9VLNK_HFT_2021221.Models
{
    public class PlaysByGenres
    {
        public Genres Genre { get; set; }
        public int Plays { get; set; }

        public override string ToString()
        {
            return $"Genre: {Genre} - All the Plays in the database:{Plays}";
        }
    }
}
