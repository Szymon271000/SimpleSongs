using System.ComponentModel.DataAnnotations;


namespace Database.Models
{
    public class Song
    {
        [Key]
        public Guid SongId { get; private set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string AlbumName { get; set; }
        public double Length { get; set; }

        public Song (string title, string author, string albumname, double length)
        {
            Title = title;
            Author = author;
            AlbumName = albumname;
            Length = length;
        }

        public Song()
        {

        }

    }
}
