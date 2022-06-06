using Database.Models;
using SimpleSongsView.Interfaces;

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
            bool checkInputs = false;
            do
            {
                title = _inputSystem.FetchStringValue("Type title (min 5 signs)");
                checkInputs = (title.Length > 5);
            } while (!checkInputs);
            do
            {
                author = _inputSystem.FetchStringValue("Type author of the song (min 5 sings)");
                if (string.IsNullOrEmpty(author))
                {
                    throw new EmptyAuthorException("Title cannot be an empty string");
                }
                checkInputs = (author.Length > 5);
            } while (!checkInputs);
            do
            {
                albumName = _inputSystem.FetchStringValue("Type album name (min 5 signs)");
                if (string.IsNullOrEmpty(albumName))
                {
                    throw new EmptyAlbumException("Album name cannot be an empty string");

                }
                checkInputs = (albumName.Length > 5);
            } while (!checkInputs);
            do
            {
                lenght = _inputSystem.FetchDecimalValue("Type the lenght of the song in seconds (min 4 sec, max 240 sec): ");
                checkInputs = (lenght > 4 && lenght <= 240);
            } while (!checkInputs);

            return new Song(title, author, albumName, lenght);
        } 
    }
}
