using System;
using System.Globalization;

namespace exConsole
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("CurrentCulture is {0}.", CultureInfo.CurrentCulture.Name);
            CultureInfo.CurrentCulture = new CultureInfo("pt-PT", false);
            Console.WriteLine("CurrentCulture is {0}.", CultureInfo.CurrentCulture.Name);


            Console.WriteLine("Frist name:  ");
             string fristName = Console.ReadLine();
             Console.WriteLine();

             Console.WriteLine("Middle name:   ");
             string middleName = Console.ReadLine();
             Console.WriteLine();

             Console.WriteLine("Last name:   ");
             string lastName = Console.ReadLine();
             Console.WriteLine();

             Console.WriteLine("Additional middle names:  ");
             string fullName = Console.ReadLine();
             Console.WriteLine();

             Console.WriteLine("Gender:   ");
             string gender = Console.ReadLine();
             Console.WriteLine();

             Console.WriteLine("age:   ");
             int age = int.Parse(Console.ReadLine());
             Console.WriteLine();

            Console.WriteLine("Date of Birthdate:   ");
            DateTime birthdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Current Job:   ");
            string job = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Height:   ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("eye colour:   ");
            string eyeColour = Console.ReadLine();
            Console.WriteLine();

           Console.WriteLine("Frist name is " + fristName);
            Console.WriteLine("Middle name is " + middleName);
            Console.WriteLine("Last name is " + lastName);
            Console.WriteLine("Full name is " + fristName + middleName + fullName + lastName);
            Console.WriteLine("Gender is " + gender);
            Console.WriteLine("Age is " + age);
            string birthdateString = birthdate.ToString("dd MM, yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Birthdate is " + birthdateString);
            Console.WriteLine("Current job is " + job);
            Console.WriteLine("Current height is  " + height + "cm");
            Console.WriteLine("Eye Colour is " + eyeColour);
        }
    }
}

