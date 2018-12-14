using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Dot
    {
        public int x;
        public int y;
        public char sym;

        public Dot(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Dot(Dot d)
        {
            x = d.x;
            y = d.y;
            sym = d.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT) x = x + offset;
            else if (direction == Direction.LEFT) x = x - offset;
            else if (direction == Direction.UP) y = y - offset;
            else if (direction == Direction.DOWN) y = y + offset;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }

        public bool IsHit(Dot d)
        {
            return d.x == this.x && d.y == this.y;
        }
    }
}
