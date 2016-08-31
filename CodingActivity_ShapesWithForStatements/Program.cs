using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingActivity_ShapesWithForStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            FilledRectangle(5, 10);

            Console.ReadKey();
        }

        static void FilledRectangle(int width, int length)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
