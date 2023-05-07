using ChallengeOne_Easy.Model;

internal class Program
{
    private static readonly IBookService _myBookService = new BookService();


    private static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to Warehouse of Books");

        Console.WriteLine();
        Console.WriteLine();
        int option = 0;
        do
        {
            Console.WriteLine("Choose a option:");

            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Create");
            Console.WriteLine("2 - Show ID");
            Console.WriteLine("3 - Show All");
            Console.WriteLine("4 - Update ID");
            Console.WriteLine("5 - Remove ID");
            

            option = Convert.ToInt32(Console.ReadLine());
            
            switch (option)
            {
                case 1:
                    Book newBook = new Book();
                    Console.WriteLine("Title of the Book: ");
                    newBook.title = Console.ReadLine();
                    Console.WriteLine("Description of the Book: ");
                    newBook.description = Console.ReadLine();
                    Console.WriteLine("ISBN Book: ");
                    newBook.isbn = Console.ReadLine();
                    Book createdBook = _myBookService.Create(newBook);
                    Console.WriteLine(createdBook);
                    Console.WriteLine("Book created whit sucess .");
                    break;
                case 2:
                    Console.WriteLine("Book ID to Show: ");
                    int idToRetrieve = Convert.ToInt32(Console.ReadLine());
                    Book retrievedBook = _myBookService.Retrieve(idToRetrieve);
                    Console.WriteLine(retrievedBook);
                    break;
                case 3:
                    List<Book> allBooks = _myBookService.RetrieveAll();
                    foreach (Book book in allBooks)
                    {
                        Console.WriteLine(book);
                    }
                    break;
                case 4:
                    Console.WriteLine("Book ID to update: ");
                    int idToUpdate = Convert.ToInt32(Console.ReadLine());
                    Book retrievedBookToUpdate = _myBookService.Retrieve(idToUpdate);
                    Console.WriteLine("New book title: ");
                    retrievedBookToUpdate.title = Console.ReadLine();
                    Console.WriteLine("New book description: ");
                    retrievedBookToUpdate.description = Console.ReadLine();
                    Console.WriteLine("New book ISBN: ");
                    retrievedBookToUpdate.isbn = Console.ReadLine();
                    Book updatedBook = _myBookService.Update(retrievedBookToUpdate);
                    Console.WriteLine(updatedBook);
                    Console.WriteLine("Book update sucess.");
                    break;
                case 5:
                    Console.WriteLine("Book ID to Remove: ");
                    int idToDelete = Convert.ToInt32(Console.ReadLine());
                    _myBookService.Delete(idToDelete);
                    Console.WriteLine("Book remove sucess.");
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


        Console.WriteLine("Thanks to use the Warehouse Book.");
    }
}