using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Coordinate // dwuwymairowa matryca, po której będziemy się poruszać wężem 
        // przechowywanie współrzędnych x i y
    {
        public Coordinate() // konstruktor bezparametrowy
        { // wartości początkowe
            X = 0;
            Y = 0;
        }
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }  
    }
}
