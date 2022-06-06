// See https://aka.ms/new-console-template for more information

using SimpleSongsController.Handler;
using SimpleSongsView;
using SimpleSongsView.Interfaces;


SongHandler songHandler = new SongHandler(new ConsoleInputSystem(), new SongConsoleView(), new MenuDisplay());
songHandler.Run();