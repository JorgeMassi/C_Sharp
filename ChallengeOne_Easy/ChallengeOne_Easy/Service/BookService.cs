using ChallengeOne_Easy.Model;
using ChallengeOne_Easy.Repository;

internal class BookService : IBookService
{
    private readonly IBookRepository _myBookRepository = new BookRepository();

    public Book Create(Book myBook)
    {
        

        if (myBook.title.StartsWith("X"))
        {
            throw new InvalidOperationException("O objecto não pode ser armazenado, ele começa com X");
        }

        return _myBookRepository.Create(myBook);
    }

    public Book Retrieve(int id)
    {
       return _myBookRepository.Retrieve(id);
    }

    public List<Book> RetrieveAll()
    {
        return _myBookRepository.RetrieveAll();
    }

    public Book Update(Book myBook)
    {
        return _myBookRepository.Update(myBook);
    }

    public void Delete(int id)
    {
        _myBookRepository.Delete(id);
    }
}