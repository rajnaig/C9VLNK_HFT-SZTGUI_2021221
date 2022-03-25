namespace C9VLNK_HFT_2021221.Models
{
    public class AlbumByPlays
    {
        public string AlbumTitle { get; set; }
        public int AlbumId { get; set; }
        public int Plays { get; set; }
        public override string ToString()
        {
            return $"Id: {AlbumId}.     \n" +
                   $"Name: {AlbumTitle} \n" +
                   $"Plays: {Plays}     \n";
        }
    }
}
