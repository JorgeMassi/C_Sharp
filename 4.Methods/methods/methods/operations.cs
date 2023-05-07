using System;
namespace methods
{
    public class operations
    {
        public static void exercise1()
        {

            Console.WriteLine("1-f-The application receives four numbers and see " +
                "which one is the highest. The result must be returned;");
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

        public static void exercise2()
        {
            Console.WriteLine("-The application receives two number a see which has the" +
                "highest result of the division of one from the other." +
                "The result must be returned; ");
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

        public static void exercise3()
        {

            Console.WriteLine("3 - The application receives four number a see which is the" +
                "lowest after beening divided" +
                " by the remaining. The result must be returned; ");
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

        public static void exercise4()
        {
            Console.WriteLine("4-The application receives two number" +
                  "and divides them. The result must be returned," +
               "with two decimal places;");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double divisionDecimal = x / y;

            Console.WriteLine(" Division decimal : " + (Math.Round(divisionDecimal, 2)));
            Console.WriteLine();
        }

        public static void exercise5()
        {

            Console.WriteLine("5-The application receives two number," +
                "calculates the multiplication " +
                "and return the word “Bizz”when even and “Buzz” when odd;\n ");
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

        public static void Menu()

        {

            Console.WriteLine("1-Exercise.1");
            Console.WriteLine("2-Exercise.2");
            Console.WriteLine("3-Exercise.3");
            Console.WriteLine("4-Exercise.4");
            Console.WriteLine("5-Exercise.5");
            Console.WriteLine("6-Exit");

        }

        public static void option()
        {
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
        }
    }
}