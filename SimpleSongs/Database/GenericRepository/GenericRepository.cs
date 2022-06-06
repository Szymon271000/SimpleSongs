using Database.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected DbContext _context = null;
        protected DbSet<T> table = null;

        public GenericRepository()
        {
            _context = new SongContext();
            table = _context.Set<T>();
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public List<T> GetAll()
        {
            return table.ToList();
        }


        public T GetById(object id)
        {
            return table.Find(id);
        }

        public T GetSingle(Func<T, bool> condition)
        {
            return table
            .Where(condition).FirstOrDefault();
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
