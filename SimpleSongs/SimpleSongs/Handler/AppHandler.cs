using SimpleSongsController.Handler;
using SimpleSongsController.Handler.Interfaces;
using SimpleSongsView;
using SimpleSongsView.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSongsController
{
    public class AppHandler
    {
        private IUserDataManager _currentDataHandler;
        private IInputSystem _input;

        public AppHandler()
        {
            _input = new ConsoleInputSystem();
            _currentDataHandler = GetSongHandler();
        }

        public SongHandler GetSongHandler()
        {
            return new SongHandler(_input, new SongConsoleView(), new MenuDisplay());
        }

        public void Run()
        {
            _currentDataHandler.Run();
        }
    }
}
