using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            //Setting Console size and constrainting it
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

            //Drawing a dot
            Dot d = new Dot(4, 5, '*');

            //Drawing a snake itself
            Snake snake = new Snake(d, 4, Direction.RIGHT);
            snake.Draw();

            //Creating food for snake
            FoodCreator foodCreator = new FoodCreator(80, 25, '*');
            Dot food = foodCreator.CreateFood();
            food.Draw();


            //Controlled snake movement
            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    snake.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(300);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(300);
                snake.Move();
            }

        }
        
    }
}
