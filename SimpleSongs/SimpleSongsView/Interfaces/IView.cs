

namespace SimpleSongsView.Interfaces
{
    public interface IView<T>
    {
        public void DisplayAll(List<T> entities);
        void DisplaySingle(T entity);

        public void DisplayAllSortered(List<T> entities);
    }
}
