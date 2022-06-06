using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
