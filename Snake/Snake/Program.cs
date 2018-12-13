using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1;
            char sym1 = '*';
            Random rnd = new Random();

            for (int i = 0; i < 25; i++)
            {
                x1 = rnd.Next(1, 30);
                y1 = rnd.Next(1, 30);
                dotDrawer(x1, y1, sym1);

            }

            Console.ReadKey();
        }

        static void dotDrawer(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }
}
