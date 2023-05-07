using System;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System.Xml.Linq;


namespace methods
{
    class Program
    {


        static void Main(string[] args)
        {


            //1.Based on the “Operations” exercises, create a method for
            //each exercise. In a single application, using the most
            //recent version of each exercise;
            Console.WriteLine("1.aplication for Operations:");
            operations.option();


            //2.Create a method named “SquareRoot” that receives one
            //numeric input(double) and returns the mathematical square
            //root value of the same. The number must be a decimal with two
            //decimal places;
            Console.WriteLine("2.one numeric number for square root:");
            double x = Convert.ToDouble(Console.ReadLine());
            SqaureRoot.Sqrt(x);

            //3.Create a method named “NumberModule” that receives one
            //numeric input(double) and returns the module value of the same;
            Console.WriteLine("3.1 number for module:");
            double y = Convert.ToDouble(Console.ReadLine());
            NumberModule.numberModule(y);


            //4.Create a method named “QuadraticEquationPos” that receives
            //three inputs and returns the positive value
            //option of the quadratic equation;

            Console.WriteLine("4. Quadratic Equation Positive");
            quadraticEquation.quadraticEquaPos();

            //5.Create a method named “QuadraticEquationNeg” that receives
            //three inputs and returns the negative value
            //option of the quadratic equation;
            Console.WriteLine("4. Quadratic Equation negative");
            quadraticEquation.quadraticEquaNeg();

            //6.Create a method named “Factorial” that receives
            //one numeric input(integer) and returns the factorial
            //value of the input;

            Console.WriteLine("6. Factorial number");
            Console.WriteLine(" 1- number for fatorial");
            Factorial.Fact();


        }
    }
}
