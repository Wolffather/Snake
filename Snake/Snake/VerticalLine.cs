using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {

        public VerticalLine(int yTop, int yBottom, int x, char sym)
        {
            dList = new List<Dot>();
            for(int y = yTop; y <= yBottom; y++)
            {
                Dot d = new Dot(x, y, sym);
                dList.Add(d);
            }
        }
    }
}
