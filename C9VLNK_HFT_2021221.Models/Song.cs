using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace C9VLNK_HFT_2021221.Models
{
    [Table("Songs")]
    public class Song
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SongId { get; set; }

        [NotMapped]
        [ForeignKey(nameof(Album))]
        public int AlbumId { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        [JsonIgnore]
        public TimeSpan Length { get; set; }
        public long LengthTicks
        {
            get
            {
                return Length.Ticks;
            }
            set
            {
                Length = TimeSpan.FromTicks(value);
            }
        }

        public int Plays { get; set; }

        public Genres SongGenre { get; set; }

        public string Producer { get; set; }

        public string SongCover { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [JsonIgnore]
        [NotMapped]
        public virtual Album Album { get; set; }
    }
}
