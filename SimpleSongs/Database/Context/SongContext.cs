using Database.Models;
using Microsoft.EntityFrameworkCore;


namespace Database.Context
{
    public class SongContext: DbContext
    {
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=SimpleSongs;Integrated Security=True");
        }
    }
}
