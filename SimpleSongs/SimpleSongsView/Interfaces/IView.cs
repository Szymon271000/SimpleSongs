using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSongsView.Interfaces
{
    public interface IView<T>
    {
        public void DisplayAll(List<T> entities);
        void DisplaySingle(T entity);

        public void DisplayAllSortered(List<T> entities);
    }
}
