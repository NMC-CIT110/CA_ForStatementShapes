using System;

namespace CA_ForStatementShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("\tFilled Rectangle");
            Console.WriteLine();
            FilledRectangle(5, 10);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("\tFilled Right Triangle (Left)");
            Console.WriteLine();
            FilledRightTriangleLeft(7);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("\tFilled Right Triangle (Right)");
            Console.WriteLine();
            FilledRightTriangleRight(7);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("\tHollow Rectangle");
            Console.WriteLine();
            HollowRectangle(5, 10);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("\tHollow Right Triangle (Left)");
            Console.WriteLine();
            HollowRightTriangleLeft(7);
            Console.WriteLine();

            Console.ReadKey();
        }

        static void FilledRectangle(int height, int width)
        {
            for (int i = 1; i <= height; i++)
            {
                Console.Write("\t");

                for (int j = 1; j <= width; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        static void FilledRightTriangleLeft(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                Console.Write("\t");

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        static void FilledRightTriangleRight(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                Console.Write("\t");

                for (int j = height - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        static void HollowRectangle(int height, int width)
        {
            for (int i = 1; i <= height; i++)
            {
                Console.Write("\t");

                if (i == 1 || i == height)
                {
                    for (int j = 1; j <= width; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int j = 1; j <= width; j++)
                    {
                        if (j == 1 || j == width)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }

                Console.WriteLine();
            }
        }

        static void HollowRightTriangleLeft(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                Console.Write("\t");

                if (i == 1 || i == height)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (j == 1 || j == i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
