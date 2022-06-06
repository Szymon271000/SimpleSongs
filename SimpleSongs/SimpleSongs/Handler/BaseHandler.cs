using SimpleSongsController.Handler.Interfaces;
using SimpleSongsView.Interfaces;


namespace SimpleSongsController.Handler
{
    public abstract class BaseHandler<T>: IUserDataManager
    {
        protected readonly IInputSystem _inputSystem;
        protected IView<T> _view;
        protected IMenuDisplay _display;
        protected string[] _availableCommands;

        public BaseHandler(IInputSystem inputSystem, IMenuDisplay menuDisplay, IView<T> view)
        {
            _inputSystem = inputSystem;
            _display = menuDisplay;
            _view = view;
        }

        public void Run()
        {
            string userInput = null;
            _display.ClearScreen();
            while (userInput != "quit")
            {
                _display.PrintOptions(new List<string>(_availableCommands));
                userInput = _inputSystem.FetchStringValue("Provide option");

                RunFeatureBasedOn(userInput);

                _display.PrintAndWaitForKey("\nPress enter to proceed...");
                _display.ClearScreen();
            }
        }

        public abstract void RunFeatureBasedOn(string userInput);
    }
}
