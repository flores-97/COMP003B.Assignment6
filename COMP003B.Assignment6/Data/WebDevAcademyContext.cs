using COMP003B.Assignment6.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.Assignment6.Data
{
    public class WebDevAcademyContext :DbContext
    {
        public WebDevAcademyContext(DbContextOptions<WebDevAcademyContext> options) : base(options) { }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<ArtistSong> ArtistSongs { get; set; }
    }
}
