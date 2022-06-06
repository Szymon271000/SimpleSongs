using Database.Models;
using SimpleSongsView.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleSongsController.Factory
{
    public class SongFactory
    {
        private readonly IInputSystem _inputSystem;

        public SongFactory(IInputSystem inputSystem)
        {
            _inputSystem = inputSystem;
        }

        public Song GetNewSong()
        {
            string title, author, albumName;
            double lenght;
            bool check = false;
            do
            {
                title = _inputSystem.FetchStringValue("Provide title");
                check = (title.Length > 5);
            } while (!check);
            do
            {
                author = _inputSystem.FetchStringValue("Provide author of the song");
                check = (author.Length > 5);
            } while (!check);
            do
            {
                albumName = _inputSystem.FetchStringValue("Provide album name");
                check = (albumName.Length > 5);
            } while (!check);
            do
            {
                lenght = _inputSystem.FetchDecimalValue("Provide the lenght of the song in seconds (min 4 sec, max 240 sec): ");
                check = (lenght > 0.04 && lenght <= 240);
            } while (!check);

            return new Song(title, author, albumName, lenght);
        } 
    }
}
