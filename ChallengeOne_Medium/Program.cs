
using ChallengeOne_Medium.Model;


internal class Program
{
    private static readonly IPhoneService _phoneService = new PhoneService();

    private static void Main(string[] args)
    {


        Console.WriteLine("Welcome to Phone Store");

        Console.WriteLine();
        int option = 0;

        do
        {
            Console.WriteLine("choose a option");

            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Create");
            Console.WriteLine("2 - Show ID");
            Console.WriteLine("3 - Show All");
            Console.WriteLine("4 - Update ID");
            Console.WriteLine("5 - Remove ID");

            Console.WriteLine();
            Console.Write("Option:  ");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Phone newPhone = new Phone();
                    Console.WriteLine("Manufacturer of Phone: ");
                    newPhone.Manufacturer = Console.ReadLine();
                    Console.WriteLine("Model of Phone: ");
                    newPhone.Model = Console.ReadLine();
                    Console.WriteLine("Operating System: ");
                    newPhone.OperatingSystem = Console.ReadLine();
                    Console.WriteLine("dimensons");
                    newPhone.Dimension = new Dimension();
                    Console.WriteLine("     Width");
                    newPhone.Dimension.Width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("    Height");
                    newPhone.Dimension.Height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("     Lenght");
                    newPhone.Dimension.Lenght = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Is mobile");
                    int mobile = 3;
                    do
                    {
                        Console.WriteLine(" write 0 - for TRUE or 1 - FALSE");
                        
                        mobile = Convert.ToInt32(Console.ReadLine());
                        if(mobile == 0 )
                        {
                            Console.WriteLine("TRUE - is Mobile");
                            newPhone.isMobile = true;
                        }
                        else if( mobile == 1)
                        {
                            Console.WriteLine("FALSE - Isn't mobile");
                            newPhone.isMobile = false;
                        }
                        else { Console.WriteLine("not valid!"); }
                       
                    } while (mobile != 0 && mobile != 1);

                    Phone createdPhone = _phoneService.Create(newPhone);
                    Console.WriteLine(createdPhone);
                    Console.WriteLine("Phone created whit sucess .");
                    break;

                case 2:
                    Console.WriteLine("Phone ID to Show: ");
                    int idToRetrieve = Convert.ToInt32(Console.ReadLine());
                    Phone retrievedPhone = _phoneService.Retrieve(idToRetrieve);
                    Console.WriteLine(retrievedPhone);
                    break;

                case 3:
                    List<Phone> allPhones = _phoneService.RetrieveAll();
                    foreach (Phone phone in allPhones)
                    {
                        Console.WriteLine(phone);
                    }
                    break;

                case 4:
                    Console.WriteLine("Phone ID to update: ");
                    int idToUpdate = Convert.ToInt32(Console.ReadLine());
                    Phone retrievedPhoneToUpdate = _phoneService.Retrieve(idToUpdate);
                    Console.WriteLine("New Phone Manufactuer: ");
                    retrievedPhoneToUpdate.Manufacturer = Console.ReadLine();
                    Console.WriteLine("New phone model: ");
                    retrievedPhoneToUpdate.Model = Console.ReadLine();
                    Console.WriteLine("New Operating System: ");
                    retrievedPhoneToUpdate.OperatingSystem = Console.ReadLine();
                    Console.WriteLine("New dimensons");
                    retrievedPhoneToUpdate.Dimension = new Dimension();
                    Console.WriteLine("      New Width");
                    retrievedPhoneToUpdate.Dimension.Width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("    New Height");
                    retrievedPhoneToUpdate.Dimension.Height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("     New Lenght");
                    retrievedPhoneToUpdate.Dimension.Lenght = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Is mobile");
                    int newmobile = 3;
                    do
                    {
                        Console.WriteLine(" write 0 - for TRUE or 1 - FALSE");
                        
                        newmobile = Convert.ToInt32(Console.ReadLine());
                        if (newmobile == 0)
                        {
                            Console.WriteLine("TRUE - is Mobile");
                            retrievedPhoneToUpdate.isMobile = true;
                        }
                        else if (newmobile == 1)
                        {
                            Console.WriteLine("FALSE - Isn't mobile");
                            retrievedPhoneToUpdate.isMobile = false;
                        }
                        else { Console.WriteLine("not valid!"); }
                       
                    } while (newmobile != 0 && newmobile != 1);

                    Phone updatedPhone = _phoneService.Update(retrievedPhoneToUpdate);
                    Console.WriteLine(updatedPhone);
                    Console.WriteLine("Phone update sucess.");
                    break;

                case 5:
                    Console.WriteLine("Phone ID to Remove: ");
                    int idToDelete = Convert.ToInt32(Console.ReadLine());
                    _phoneService.Delete(idToDelete);
                    Console.WriteLine("Phone remove sucess.");
                    break;
                default:
                    if (option != 0)
                    {
                        Console.WriteLine("Option " + option + " don't exist, try again.");
                    }
                    break;
            }
            Console.ReadKey();
            Console.WriteLine();
        } while (option != 0);


        Console.WriteLine("Thanks to use the Phone Store.");
    }
}
