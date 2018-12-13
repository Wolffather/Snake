using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Dot tail, int length, Direction direction)
        {
            this.direction = direction;
            dList = new List<Dot>();

            for(int i = 0; i < length; i++)
            {
                Dot d = new Dot(tail);
                d.Move(i, direction);
                dList.Add(d);
            }
        }

        internal void Move()
        {
            Dot tail = dList.First();
            dList.Remove(tail);
            Dot head = GetNextDot();
            dList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Dot GetNextDot()
        {
            Dot head = dList.Last();
            Dot nexDot = new Dot(head);
            nexDot.Move(1, direction);
            return nexDot;
        }
    }
}
