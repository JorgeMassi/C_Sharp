using System;
using System.Buffers.Text;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;

namespace operations
{
    class Program
    {
        static void Main(string[] args)
        {

            static void exercise1()
            {
                //1-The application receives four numbers and see
                //which one is the highest. The result must be returned;

                Console.WriteLine("1-four numbers: ");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());
                int temp;

                if (a >= b)
                {
                    temp = a;
                    
                    if (temp >= b)
                    {
                        temp = b;
                    }
                    if (temp >= c)
                    {
                        temp = c;
                    }
                }
                else
                {
                    temp = d;
                }
                Console.WriteLine("the number is " + temp);
                Console.WriteLine();

            }

            static void exercise2()
            {
                //2-The application receives two number a see which has the
                //highest result of the division of one from the other.
                //The result must be returned;



                Console.WriteLine("2- two numbers: ");
                int e = int.Parse(Console.ReadLine());
                int f = int.Parse(Console.ReadLine());
                int divisionFrist = e / f;
                int divisionSecond = f / e;

                if (divisionFrist > divisionSecond)
                {
                    Console.WriteLine(" the hightest result is the division of " + divisionFrist);
                }
                else
                {
                    Console.WriteLine(" the hightest result is the division of " + divisionSecond);
                }

                Console.WriteLine();
            }

            static void exercise3()
            {
                //3-The application receives four number a see which is the
                //lowest after beening divided
                //by the remaining. The result must be returned;

                Console.WriteLine("3 - four numbers: ");
                double m = int.Parse(Console.ReadLine());
                double n = int.Parse(Console.ReadLine());
                double o = int.Parse(Console.ReadLine());
                double p = int.Parse(Console.ReadLine());
                double temp;
                double restM = m / (n + o + p);
                double restN = n / (m + o + p);
                double restO = o / (m + n + p);
                double restP = p / (m + n + o);


                if (restM <= n)
                {
                    temp = m;
                    if (temp <= restN)
                    {
                        temp = n;
                    }
                    if (temp <= restO)
                    {
                        temp = o;
                    }
                }
                else
                {
                    temp = p;
                }
                Console.WriteLine("the number is " + temp);

                Console.WriteLine();
            }

            static void exercise4()
            {
                //4-The application receives two number
                //and divides them. The result must be returned,
                //with two decimal places;

                Console.WriteLine("4 - two numbers: ");
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double divisionDecimal = x / y;

                Console.WriteLine(" Division decimal : " + (Math.Round(divisionDecimal, 2)));
                Console.WriteLine();
            }

            static void exercise5()
            {
                //5-The application receives two number,
                //calculates the multiplication
                //and return the word “Bizz”when even and “Buzz” when odd;

                Console.WriteLine("5 - two numbers: ");
                int k = int.Parse(Console.ReadLine());
                int l = int.Parse(Console.ReadLine());

                int multiplicaction = k * l;

                if (multiplicaction % 2 == 0)
                {
                    Console.WriteLine("Bizz");
                }
                else
                    Console.WriteLine("BUZZ");
                Console.WriteLine();

            }
            //6-The application that allows the user to select
            //the application which allows the user to
            //select application of the above wants to execute.
            //The selection if based on providing a selection code(Md#ID#). A Switch must be used;

            static void Menu()

            {

                Console.WriteLine("1-Exercise.1");
                Console.WriteLine("2-Exercise.2");
                Console.WriteLine("3-Exercise.3");
                Console.WriteLine("4-Exercise.4");
                Console.WriteLine("5-Exercise.5");
                Console.WriteLine("6-Exit");

            }

            
            int option = 0;
            do
            {
                Menu();
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Exercise.1");
                        exercise1();
                        break;
                    case 2:
                        Console.WriteLine("Exercise.2");
                        exercise2();
                        break;
                    case 3:
                        Console.WriteLine("Exercise.3");
                        exercise3();
                        break;
                    case 4:
                        Console.WriteLine("Exercise.4");
                        exercise4();
                        break;
                    case 5:
                        Console.WriteLine("Exercise.5");
                        exercise5();
                        break;
                    case 6:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        break;
                }
            }
            while (option != 6);
            Console.WriteLine();

            //7-The application that receives two number
            //and one operator option and executes the
            //calculation.The result must be returned.The operation codes are:
            //• SUM;
            //• SUB;
            //• MLT;
            //• DIV;
            //. A Switch must be used;

            Console.WriteLine("7 - two numbers: ");
            int j = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());

            
            static void ShowMenu()

            {

                Console.WriteLine("1 - SUM");
                Console.WriteLine("2 - SUB");
                Console.WriteLine("3 - MLT");
                Console.WriteLine("4 - DIV");
                Console.WriteLine("0 - Exit");

            }
            ShowMenu();
            int escolha = 0;
            escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("SUM  =   " + (i + j));
                    break;
                case 2:
                    Console.WriteLine("SUB  =   " + (i - j));
                    break;
                case 3:
                    Console.WriteLine("MLT  =   " + (i * j));
                    break;
                case 4:
                    Console.WriteLine("DIV  =   " + (i / j));
                    break;
                case 0:
                    Console.WriteLine("EXIT");
                    break;
                default:
                    break;
            }


            //8-Add the application on 7 to the application on 6;
        }
    }
}

