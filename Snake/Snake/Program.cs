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

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            //Drawing the frame
            HorizontalLine hLine1 = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine hLine2 = new HorizontalLine(0, 78, 24, '+');
            VerticalLine vLine1 = new VerticalLine(0, 24, 0, '+');
            VerticalLine vLine2 = new VerticalLine(0, 24, 78, '+');
            hLine1.Draw();
            hLine2.Draw();
            vLine1.Draw();
            vLine2.Draw();

            Console.ReadKey();


        }
        
    }
}
