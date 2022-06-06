using SimpleSongsView.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSongsView
{
    public class ConsoleInputSystem : IInputSystem
    {
        public decimal FetchDecimalValue(string prompt)
        {
            decimal result;
            while (!Decimal.TryParse(FetchStringValue(prompt), out result)) continue;
            return result;
        }

        public string FetchStringValue(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
