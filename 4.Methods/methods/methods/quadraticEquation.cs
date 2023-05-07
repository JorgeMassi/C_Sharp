using System;
namespace methods
{
	public class quadraticEquation
	{
		public static void quadraticEquaPos()
		{
            double a, b, c;
            Console.WriteLine(" Quadratic Equation");
            Console.WriteLine(" aX^2 + bX + c = 0");
            Console.WriteLine("Valor de a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor de b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor de c");
            c = Convert.ToDouble(Console.ReadLine());
            
            double equation = (b * b) - (4 * a * c);

            double x = (-b + (Math.Sqrt(equation)) / (2 * a));
            Console.WriteLine("Result: = " + x);
           
            
            Console.ReadLine();
        }
        public static void quadraticEquaNeg()
        {
            double a, b, c;
            Console.WriteLine(" Quadratic Equation");
            Console.WriteLine(" aX^2 + bX + c = 0");
            Console.WriteLine("Valor de a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor de b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor de c");
            c = Convert.ToDouble(Console.ReadLine());
            // 
            double equation = (b * b) - (4 * a * c);

            double x = (-b - (Math.Sqrt(equation)) / (2 * a));
            Console.WriteLine("Result: = " + x);


            Console.ReadLine();
        }
    }
}

