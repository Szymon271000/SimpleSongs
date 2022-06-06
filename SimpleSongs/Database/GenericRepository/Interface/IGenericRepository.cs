using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface IGenericRepository<T> where T : class
    {
        void Insert(T obj);
        void Delete(object id);
        List<T> GetAll();
        T GetSingle(Func<T, bool> condition);
        void Save();
        T GetById(object id);
    }
}
