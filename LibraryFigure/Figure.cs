using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFigure
{
    public class Figure
    {
        /// <summary>
        /// Метод, для определения фигуры.
        /// </summary>
        /// <param name="array"></param>
        public double DesideMethodFigureType(params double[] array)
        {
            //Проверка: являются ли элементы массива положительными числами.
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 0)
                {
                    throw new Exception("Введите положительные числа");
                }
            }

            double result = default(double);
            string text = default(string);
            if (array.Length == 1)
            {
                result = DesideCircleArea(array[0]);
                text = "Площадь круга: {0}";
            }
            else if (array.Length == 3)
            {
                result = DesideTriangleArea(array[0], array[1], array[2]);
                text = "Площадь треугольника: {0}";
            }
            else
            {
                throw new Exception("Данная фигура не существует");
            }

            Console.WriteLine(text, result);
            return result;
        }
        #region private functions
        //Метод, который вычисляет площадь Круга.
        public double DesideCircleArea(double r)
        {
            double s = 3.14 * (Math.Pow(r, 2));
            return Math.Round(s, 2);
        }

        //Метод, который вычисляет площадь Треугольника.
        public double DesideTriangleArea(double a, double b, double c)
        {
            //Проверка: является ли Сумма длин двух сторон треугольника больше третьей стороны.
            if ((a < (b + c)) & (b < (a + c)) & (c < (a + b)))
            {
                string n = "Треугольник является прямоугольным";
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                //Проверка: является ли прямоугольным треугольник.
                if (a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2)) ||
                   b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2)) ||
                   c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)))
                {
                    Console.WriteLine(n);
                }

                return Math.Round(s, 2);
            }
            else
            {
                throw new Exception("Сумма длин двух сторон треугольника должна быть больше третьей стороны.");
            }

        }
        #endregion
    }
}
