using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Половинное_деление
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.Clear();
                    Console.WriteLine("Введите значения уравнения");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Экстемума");
                    double E = double.Parse(Console.ReadLine());
                    Console.WriteLine("Кол-во Итераций");
                    double lim = double.Parse(Console.ReadLine());

                    double Sx = 0;

                    double Fa = Math.Pow(a, 5) * 6 + 3 * a;
                    double Fb = Math.Pow(b, 5) * 6 + 3 * b;
                    double f1 = Fa * Fb;
                    if (f1 < 0)
                    {
                        for (double i = 0; i <= lim; i++)
                        {
                            Console.WriteLine("Условие выполнено");

                            double x = (a + b) / 2;
                            Sx = Math.Pow(x, 5) * 6 + 3 * x;
                            Console.WriteLine(Sx);
                            if (Fa * Sx < 0)
                            {
                                b = x;
                                double x2 = (a + b) / 2;
                                Sx = Math.Pow(x2, 5) * 6 + 3 * x2;

                            }
                            else if (Fa * Sx > 0)
                            {
                                a = x;
                                double x2 = (a + b) / 2;
                                Sx = Math.Pow(x2, 5) * 6 + 3 * x2;

                            }

                            Console.ReadLine();

                        }


                    }
                    else if (f1 > 0)
                    {
                        Console.WriteLine("Условие не выполнено");
                    }
                }

                catch
                {
                    Console.WriteLine("Ошибка");
                }
            }

        }


        static void N(double Fa, double Fb, double x)
        {
            Fa = Math.Pow(x, 5) * 6 + 3 * x;
            Fb= Math.Pow(x, 5) * 6 + 3 * x;

            return;
        }
    }
}
