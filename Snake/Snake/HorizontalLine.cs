using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            dList = new List<Dot>();
            for(int x = xLeft; x <= xRight; x++)
            {
                Dot d = new Dot(x, y, sym);
                dList.Add(d);
            }
        }
    }
}
