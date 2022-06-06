using Database.Models;
using SimpleSongsView.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSongsView
{
    public class SongConsoleView : IView<Song>
    {
        public void DisplayAll(List<Song> entities)
        {
            entities.ForEach(x => DisplaySingle(x));
        }

        public void DisplayAllSortered(List<Song> entities)
        {
            entities.OrderBy(x => x.Title).ToList().ForEach(x => DisplaySingle(x));
        }

        public void DisplaySingle(Song entity)
        {
            Console.WriteLine($"Title: {entity.Title} || Author: {entity.Author} || Album name: {entity.AlbumName} || Lenght: {entity.Length}");
        }
    }
}
