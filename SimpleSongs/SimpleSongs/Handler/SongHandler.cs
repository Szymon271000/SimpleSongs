using Database.Models;
using Database.SongRepository;
using SimpleSongsController.Factory;
using SimpleSongsView.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSongsController.Handler
{
    public class SongHandler: BaseHandler<Song>
    {
        private SongRepository _songRepository;
        private SongFactory _songFactory;
        public SongHandler(IInputSystem inputSystem, IView<Song> view, IMenuDisplay display) : base(inputSystem, display, view)
        {
            _songRepository = new SongRepository();
            _songFactory = new SongFactory(inputSystem);
            _availableCommands = new string[] { "1. Create new song", "2. Display all songs", "3. Delete existing song", "4. Display songs sortered by their titles", "5. Display a specific song", "Type quit to exit"};
        }

        public override void RunFeatureBasedOn(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    AddSong();
                    break;
                case "2":
                    DisplayAllSongs();
                    break;
                case "3":
                    DeleteSong();
                    break;
                case "4":
                    DisplaySongsSortered();
                    break;
                case "5":
                    DisplayASpecificSong();
                    break;
                default:
                    _display.PrintMessage("Incorrect input, please type number of option");
                    break;
            }
        }

        public void DisplayASpecificSong()
        {
            string title = _inputSystem.FetchStringValue("Insert the name of the title to search");
            string author = _inputSystem.FetchStringValue("Insert the name of the author of the song to search");
            string album = _inputSystem.FetchStringValue("Insert the name of the album of the song to search");
            var songToFind = _songRepository.GetAll().FirstOrDefault(x => x.Author == author && x.Title == title
            && x.AlbumName == album);
            if (songToFind != null)
            {
                _view.DisplaySingle(songToFind);
            }
            else
            {
                _display.PrintMessage("This song cannot be shown because it does not exist");
                return;
            }
        }

        public void DisplaySongsSortered()
        {
            var songs = _songRepository.GetAll();
            _view.DisplayAllSortered(songs);
        }

        public void AddSong()
        {
            var song = _songFactory.GetNewSong();
            var songToBeAdded = _songRepository.GetAll().FirstOrDefault(x=> x.Author == song.Author && x.Title == song.Title 
            && x.AlbumName == song.AlbumName && x.Length == song.Length);
            if (songToBeAdded == null)
            {
                _songRepository.Insert(song);
                _songRepository.Save();
                _display.PrintMessage("Your song has been added");
            }
            else
            {
                _display.PrintMessage("This song exists already");
                return;
            }
        }

        public void DisplayAllSongs()
        {
            List<Song> songs = _songRepository.GetAll();
            _view.DisplayAll(songs);
        }

        public void DeleteSong()
        {
            DisplayAllSongs();
            string title = _inputSystem.FetchStringValue("Insert the name of the title to delete");
            string author = _inputSystem.FetchStringValue("Insert the name of the author of the song to delete");
            string album = _inputSystem.FetchStringValue("Insert the name of the album of the song to delete");
            var songToBeDeleted = _songRepository.GetAll().FirstOrDefault(x => x.Author == author && x.Title == title
            && x.AlbumName == album);
            if (songToBeDeleted != null)
            {
                _songRepository.Delete(songToBeDeleted);
                _songRepository.Save();
                _display.PrintMessage("Your song has been deleted");
            }
            else
            {
                _display.PrintMessage("This song cannot be deleted because it does not exist");
                return;
            }
        }
    }
}
