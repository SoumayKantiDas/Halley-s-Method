using System;

namespace Halley_s_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Re:
            Console.WriteLine("Enter the value of a and b: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            //double accuracy = 0.0000000000001;
            Console.WriteLine("Enter the acurracy number");
            double accuracy = Convert.ToDouble(Console.ReadLine());
            double x0;
            double x1;


            if (a < b && Function(a) * Function(b) < 0)
            {
                x0 = (a + b) / 2;

                while (true)
                {

                    x1 = x0 - (2 * Function(x0)*DerivFunction(x0)/(2*(DerivFunction(x0)*DerivFunction(x0))-(Function(x0)*DerivFunction(x0))));
                    Console.WriteLine("Value of X1: {0}", x1);
                    if (Math.Abs(Function(x1)) <= accuracy)
                    {
                        Console.WriteLine("Root is: {0}", x1);
                        break;
                    }

                    else
                    {

                        if (Function(x1) == 0)
                        {
                            Console.WriteLine("Root is: {0}", x1);
                            break;
                        }
                        else
                        {
                            x0 = x1;
                        }
                    }

                }
            }
            else
            {
                goto Re;
            }


        }
        static double Function(double x)
        {
            return x * x * x - x - 1;
        }

        static double DerivFunction(double x)
        {
            return 3 * x * x - 1;
        }
        static double DoubleDrivFunction(double x)
        {
            return  6*x;
        }
    }
   
}
