
namespace SimpleSongsView.Interfaces
{
    public interface IInputSystem
    {
        public string FetchStringValue(string prompt);
        public double FetchDecimalValue(string prompt);
    }
}
