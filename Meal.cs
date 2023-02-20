using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Meal
    {
        public Meal()
        {
            Random rand = new Random();
           var x = rand.Next(1,20);// w poziomie
           var y = rand.Next(1, 20);// w pionie

            CurrentTarget = new Coordinate (x,y);
            Draw();
        }
        public Coordinate CurrentTarget { get; set; } // PRZECHOWANIE Xów i Yów

        void Draw()
        {
            Console.SetCursorPosition(CurrentTarget.X, CurrentTarget.Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("$");
        }
    }
}
