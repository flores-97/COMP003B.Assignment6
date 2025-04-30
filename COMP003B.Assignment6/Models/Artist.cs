using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public virtual ICollection<ArtistSong>? ArtistSongs { get; set; }
        public int Age { get; set; }//added
    }
}
