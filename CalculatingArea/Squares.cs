using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingArea
{
    
    public class Squares
    {
        /// <summary>
        /// Расчитывает площадь треугольника
        /// </summary>
        public static double SquareTriangle(double a, double b, double c)
        {
            if (VerificationTriangle(a, b, c))
            {
                var p = (a + b + c) / 2;
                var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return Math.Round(s,2);
            }
            else throw new ArgumentException("Недопустимое значение");
        }
        /// <summary>
        /// Расчитывает площадь круга, округление до сотых
        /// </summary>
        public static double SquareCircle(double r)
        {
            if (r >= 0)
            {
                var s1 = Math.PI * r * r;
                return Math.Round(s1,2);
            }
            else throw new ArgumentException("Недопустимое значение");
            
        }

        /// <summary>
        /// Проверка является ли треугольник на прямоугольность
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool RightTriangle(double a, double b, double c)
        {
            if (VerificationTriangle(a, b, c))
            {
                if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == b * b + a * a)
                    return true;
                return false;
            }
            else throw new ArgumentException("Недопустимое значение");
        }

        /// <summary>
        /// Проверка на существование треугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static bool VerificationTriangle(double a, double b, double c)
        {
            return (a > 0 && b > 0 && c > 0 && a < b + c && b < a + c && c < b + a) ? true : false;
        }
    }
}
