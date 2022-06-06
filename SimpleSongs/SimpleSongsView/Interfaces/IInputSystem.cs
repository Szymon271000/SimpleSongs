using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSongsView.Interfaces
{
    public interface IInputSystem
    {
        public string FetchStringValue(string prompt);
        public double FetchDecimalValue(string prompt);
    }
}
