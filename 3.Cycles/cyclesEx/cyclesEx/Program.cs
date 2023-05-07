using System;

namespace cyclesEx
{
	class Program
	{
		static void Main(string[] args)
		{
			//#region 1
			////1. The application receives a number and returns the table of 5.
			////User the for cycle;


			//Console.WriteLine("1 - Table of 5");
			//int number = 5;

			//for (int i = 0; i <= 10; i++)
			//{
			//	Console.WriteLine(i + "x" + number + "=" + i * number);
			//}
			//#endregion

			//#region 2
			////2.Update the application 1 so that the calculated table is
			////based on a provided number by the user. User the for cycle;

			//Console.WriteLine("2 - provided a number:");
			//int provNumber = Convert.ToInt32(Console.ReadLine());

			//for (int j = 0; j <= 10; j++)
			//{
			//	Console.WriteLine($"{j}x{provNumber} = {j * provNumber}");
			//}
			//#endregion

			//#region 3
			////3.The application draws half a tree with the character *.
			////The number of lines is provided by the user. Use the for cycle;

			//Console.WriteLine(" 3- provided the number of *: ");
			//int star = Convert.ToInt32(Console.ReadLine());

			//for (int i = 1; i <= star; i++)
			//{
			//	for (int j = 1; j <= i; j++)
			//	{
			//		Console.Write("*");
			//	}

			//	Console.WriteLine();
			//}

			//#endregion

			//#region 4
			//// 4. The application draws a full tree with the character *.
			//// The number of lines is provided by the user. User the for cycle;

			//Console.WriteLine(" 4- provided the number of *: ");
			//int secondStar = Convert.ToInt32(Console.ReadLine());
          
   //         for (int i = 0; i <= secondStar; i++)
   //         {
   //             for (int j = 0; j <= (secondStar - i); j++)
   //             {
   //                 Console.Write(" ");
   //             }
   //             for (int a = 0; a < i * 2; a++)
   //             {
   //                 Console.Write("*");
   //             }
   //             Console.WriteLine();
   //         }


   //         #endregion

   //         #region 5
   //         // 5. The application is identical to application 3, using the Do/While cycle;
   //         Console.WriteLine(" 5- provided the number of *: ");
			//int thierdtar = Convert.ToInt32(Console.ReadLine());

			//int m = 0;
			//do
			//{
			//	int n = 0;
			//	while(n <= m)
			//	{
			//		Console.Write("*");
			//		n++;
			//	}
			//	Console.WriteLine();
			//	m++;
			//}
			//while (m < thierdtar);
   //         #endregion

   //         #region 6
   //         // 6.The application is identical to application 3, using the While cycle;
   //         Console.WriteLine(" 6- provided the number of *: ");
			//int starSix = Convert.ToInt32(Console.ReadLine());
			//int alto = 0;
			//int baixo = 0;

			//while (alto < starSix)
			//{
			//	baixo = 0;
			//	while (baixo <= alto)
			//	{
			//		Console.Write("*");
			//		baixo++;
			//	}
			//	Console.WriteLine();
			//	alto++;
			//}
   //         #endregion

   //         #region 7
   //         // 7. The application is identical to application 4, using the Do/ While cycle;
   //         Console.WriteLine(" 7- provided the number of *: ");
			//int sevenStar = Convert.ToInt32(Console.ReadLine());

			//int o = 1;
			//do
			//{
			//	int p = 1;
			//	while (p <= (sevenStar - o))
			//	{
			//		Console.Write(" ");
			//		p++;

			//	}
			//	int b = 1;
   //             while (b < o * 2)
			//	{
			//		Console.Write("*");
			//		b++;
			//	}
			//	Console.WriteLine();
			//	o++;
			//}
			//while (o <= sevenStar);

   //         #endregion

   //         // 8. The application draws a full tree, with odd numbers per row,
   //         // with the character *. The number of lines is provided by the user.
   //         // User the for cycle;

   //         #region 8
   //         Console.WriteLine(" 8- provided the number of *: ");
   //         int eightStar = Convert.ToInt32(Console.ReadLine());

   //         for (int z = 1; z <= eightStar; z++)
   //         {
   //             for (int y = 1; y <= (eightStar - z); y++)
   //             {
   //                 Console.Write(" ");
   //             }
   //             for (int c = 1; c < z * 2; c++)
   //             {
   //                 Console.Write("*");
   //             }
   //             Console.WriteLine();
   //         }

   //         #endregion


            // 9 . The application draws a full tree, with equal characters to the row,
            // with the character *. The number of lines is provided by the user.

            Console.WriteLine(" 9- provided the number of *: ");
            int nineStar = Convert.ToInt32(Console.ReadLine());

            for (int w = 1; w <= nineStar; w++)
            {
                for (int r = 1; r <= nineStar - w; r++)
                {
                    Console.Write(" ");
                }
                for (int d = 2; d < w * 2; d++)
                {
					if (d % 2 == 0)
					{
						Console.Write(" ");
					}	
					else
						Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}