using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {

        protected List<Dot> dList;

        public void Draw()
        {
            foreach (Dot d in dList)
            {
                d.Draw();
            }
        }
    }
}
