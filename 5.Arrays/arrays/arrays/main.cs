using System;
using System.Net.NetworkInformation;
using System.Threading;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.The application receives five numbers and returns them
            ////ordered from lowest to largest.The numbers before
            ////being displayed must be stored in an array;


            //int[] arr = new int[5];
            //Console.WriteLine("1.five numbers:");
            //arr[0]= Convert.ToInt32(Console.ReadLine());
            //arr[1] = Convert.ToInt32(Console.ReadLine());
            //arr[2] = Convert.ToInt32(Console.ReadLine());
            //arr[3] = Convert.ToInt32(Console.ReadLine());
            //arr[4] = Convert.ToInt32(Console.ReadLine());

            //Array.Sort(arr);
            //Console.WriteLine("array:" + arr[0]);
            //Console.WriteLine("array:" + arr[1]);
            //Console.WriteLine("array:" + arr[2]);
            //Console.WriteLine("array:" + arr[3]);
            //Console.WriteLine("array:" + arr[4]);




            ////2.The application receives five numbers and returns them
            ////ordered from lowest to largest.The numbers must be
            ////stored in an array as they are received;

            //int j;
            //int[] arrSecond = new int[5];
            //Console.WriteLine("2.five numbers:");

            //for (j = 0; j < 5; j++)
            //{
            //    arrSecond[j] = Convert.ToInt32(Console.ReadLine());
            //}
            //Array.Sort(arrSecond);
            //for (j = 0; j < 5; j++)
            //{
            //    Console.WriteLine("array:" + arrSecond[j]);
            //}


            ////3.The application receives five numbers and returns the average.
            ////The initial numbers must be stored in a array;

            //int l;
            //int[] arrTherd = new int[5];
            //int sum = 0;
            //float average = 0.0F;
            //Console.WriteLine("3.five numbers:");
            //for (l = 0; l < 5; l++)
            //{
            //    arrTherd[l] = Convert.ToInt32(Console.ReadLine());
            //    sum += arrTherd[l];
            //    average = (float)sum / 5;
            //}

            //Console.WriteLine("average:" + average);

            //4.The application receives an X number of inputs.
            //It must return the correspondent value on request,
            //on after each request it must ask the user if it desires
            //another retrieval.The information must be stored in an array;
            //int size = 0;
            //Console.WriteLine("4.X numbers:");
            //int[] arrayNumberFour = new int[size];
            //for (int k = 0; k < size; k++)
            //{
            //    arrayNumberFour[k] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("number of the position on array");
            




            //5.Create the tic tac toe game.The data must be
            //stored in an array and the request played position is
            //provided by the user with two coordinates.The application
            //must validate it the user play is valid;

           // TicTac.ticTacToe();
            Tic.PlayXorO();

        }
    }
}
    

         