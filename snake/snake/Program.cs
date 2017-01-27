﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, 'x');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, 'x');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, 'x');
            VerticalLine righttLine = new VerticalLine(0, 24, 78, 'x');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            righttLine.Draw();

            point p = new point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
               
            }
            

            
        }
        }

       
    }

