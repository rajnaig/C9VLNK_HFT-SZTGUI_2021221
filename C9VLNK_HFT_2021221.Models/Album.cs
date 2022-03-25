using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace C9VLNK_HFT_2021221.Models
{
    [Table("Albums")]
    public class Album
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int AlbumId { get; set; }
        [Required]
        public string AlbumTitle { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [ForeignKey(nameof(Artist))]
        public int ArtistId { get; set; }

        [JsonIgnore]
        [NotMapped]
        public virtual Artist Artist { get; set; }

        public string AlbumCover { get; set; }

        [JsonIgnore]
        [NotMapped]
        public virtual ICollection<Song> Songs { get; set; }

        public Album()
        {
            this.Songs = new HashSet<Song>();
        }
        public override string ToString()
        {
            return $"Id: {AlbumId}.                  \n" +
                   $"Name: {AlbumTitle}              \n" +
                   $"Release Date: {ReleaseDate}     \n";
        }
    }
}
