
namespace Database
{
    public interface IGenericRepository<T> where T : class
    {
        void Insert(T obj);
        void Delete(T song);
        List<T> GetAll();
        void Save();
    }
}
