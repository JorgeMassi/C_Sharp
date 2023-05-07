using System;
namespace methods
{
	public class Factorial
	{
		static public void  Fact()
		{
            Console.WriteLine("Enter the number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int x = 1; x <= a; x++)
            {
                fact = fact * x;
                Console.WriteLine(fact);
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
	
}

