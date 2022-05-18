using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatingArea;

namespace CalculatingSquares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var s = Squares.SquareTriangle(a, b, c);
            var s1 = Squares.SquareCircle(r);
            Console.WriteLine(Squares.RightTriangle(a, b, c));
            Console.WriteLine(s);
            Console.WriteLine(s1);
        }
    }
}
