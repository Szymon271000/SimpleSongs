using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSongsView.Interfaces
{
    public class MenuDisplay : IMenuDisplay
    {
        public void ClearScreen()
        {
            Console.Clear();
        }

        public void PrintAndWaitForKey(string content)
        {
            Console.WriteLine(content);
            Console.ReadKey();
        }

        public void PrintMany<T>(List<T> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintMessage(string content)
        {
            Console.WriteLine(content);
        }

        public void PrintOptions(List<string> options)
        {
            Console.WriteLine("\n~~~~~~  O P T I O N S   A V A I L A B L E  ~~~~~~\n");
            options.ForEach(Console.WriteLine);
            Console.WriteLine("\nS E L E C T   O P T I O N   A N D   P R E S S   E N T E R  :\n");
        }
    }
}
