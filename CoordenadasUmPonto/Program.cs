using System;

namespace CoordenadasUmPonto
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] XY = Console.ReadLine().Split();

            double x = double.Parse(XY[0]);
            double y = double.Parse(XY[1]);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
                {
                    Console.WriteLine("Eixo Y");
                }
            else if (y == 0)
                {
                    Console.WriteLine("Eixo X");
                }
            else if(x > 0.0 && y > 0.0)
                    {
                        Console.WriteLine("Q1");
                    }
            else if (x < 0.0 && y > 0.0)
                    {
                        Console.WriteLine("Q2");
                    }
            else if (x < 0.0 && y < 0.0)
                    {
                        Console.WriteLine("Q3");
                    }
            else if (x > 0.0 && y < 0.0)
                    {
                        Console.WriteLine("Q4");
                    }
            else
            {
                Console.WriteLine();
            }
                }


            }
        }
