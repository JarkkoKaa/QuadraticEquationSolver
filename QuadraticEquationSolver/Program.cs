using System;

namespace QuadraticEquationSolver
{
    class Program
    {
        static void EquationSolver()
        {
            int a, b, c, result;
            // Equation formula: 
            // ax^2 + bx + c = 0
            a = 2;
            b = 5;
            c = -3;
            result = 0;
            // 2x^2 + 5x - 3 = 0 should give x1 = 0,5 and x2 = -3
            if (b != 0 && c != 0)
            {
                double[] x = new double[2];

                Console.WriteLine("{0}x^2 {1}x {2} = 0", a, (b < 0) ? "- " + (b * (-1)) : "+ " + b, (c < 0) ? "- " + c : "+ " + c);
                // get squareroot
                var squareRoot = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
                var divider = 2 * a;

                x[0] = (-b + squareRoot) / divider;
                x[1] = (-b - squareRoot) / divider;

                PrintEquation(0,x);
            }
            else if (b == 0)
            {
                double[] x = new double[1];

                Console.WriteLine("{0}x^2 {1} = 0", a, (c < 0) ? "- " + (c * (-1)) : "+ " + c);
                if (c < 0)
                    c *= (-1);
                var divide = c / a;
                x[0] = Math.Sqrt(divide);

                PrintEquation(1,x);
            }
            else if (c == 0)
            {
                double[] x = new double[2];
                x[0] = result;
                x[1] = b;

                Console.WriteLine("{0}x^2 {1}x = {2}", a, (b < 0) ? "- " + (b * (-1)) : "+ " + b, result);

                if (result == 0)
                {
                    x[1] *= (-1);
                }
                else
                {
                    x[0] *= (-1);
                    x[1] *= (-1);
                    x[1] += result;
                }

                PrintEquation(2, x);
            }
        }

        static void PrintEquation(int print, double[] x)
        {
            switch (print)
            {
                case 0:
                    // if both x:s are equal
                    if (x[0].Equals(x[1]))
                        Console.WriteLine("x: {0}", x[0]);
                    else
                        Console.WriteLine("x1: {0} and x2: {1}", x[0], x[1]);
                    break;
                case 1:
                    Console.WriteLine("+-{0}", x[0]);
                    break;
                case 2:
                    Console.WriteLine("x = {0} or x = {1}", x[0], x[1]);
                    break;
            }
        }

        static void Main(string[] args)
        {
            EquationSolver();
        }
    }
}
