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
            int x = 1, y = 5;
            char sym = '*';

            Dot dot = new Dot(x, y, sym);
            dot.Draw();
            Console.ReadKey();
            
        }
        
    }
}
