using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
    public class Song
    {
        public int SongId { get; set; }
        [Required]
        public string Title { get; set; }
        public virtual ICollection<ArtistSong>? ArtistSongs { get; set; }
    }
}
