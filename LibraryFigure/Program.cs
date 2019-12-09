using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure name = new Figure();
            name.DesideMethodFigureType(3, 4, 5);

            Console.ReadKey();
        }
    }
}
