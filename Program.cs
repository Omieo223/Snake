using Snake;
using System;

namespace Snake
{
    class Progrma
    {
        static void Main(string[] args)
        {
            //ZMIENNNE:
            Console.CursorVisible = false; // żeby biały cursor nie migał
            bool exit = false;
            double frameRate = 1000 / 5.0; // 1000ms/prędkość czyli liczba klatek na sekunde
            DateTime lastDate = DateTime.Now; // inicjalizacja obecnej daty
            Meal meal = new Meal();
            Snake snake = new Snake();

         //_______________________________________________________________________________________________________________

            //game loop
            while (!exit)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();
                    // pętla będzie sobie działała w przypadku naciśnińcia klawisza wykona się jakaś akcja

                    switch(input.Key)
                    {
                        case ConsoleKey.Escape: // naciśnięcie Escape
                            exit = true;  // wyjście z gry
                            break;
                        case ConsoleKey.LeftArrow: // strzałka w lewo..
                            snake.Direction = Direction.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            snake.Direction = Direction.Right;
                            break;
                        case ConsoleKey.UpArrow:
                            snake.Direction = Direction.Up;
                            break;
                        case ConsoleKey.DownArrow:
                            snake.Direction = Direction.Down;
                            break;
                    }


                }

                // Total.Milliseconds czyli bierzemy ms z różnicy ms
                if ((DateTime.Now - lastDate).TotalMilliseconds >= frameRate)
                // jeżeli  ( (obecny czas - ostatnie sprawdzenie) >= czas przeznaczony na jedną klatke wtedy akcja gry {}
                {
                    //game action
                    snake.Move();

                    if (meal.CurrentTarget.X == snake.HeadPosition.X
                        && meal.CurrentTarget.Y == snake.HeadPosition.Y)
                    {
                        snake.EatMeal();
                        meal = new Meal();
                        frameRate /= 1.1; // zwiększanie tempa
                    }

                    if (snake.GameOver)
                    {
                        Console.Clear();
                        Console.Write($"GAME OVER. YOUR SCORE:{snake.Lenght}");
                        exit = true;
                        Console.ReadLine();
                    }
                    lastDate = DateTime.Now;
                }
            }
        }
    }
}
