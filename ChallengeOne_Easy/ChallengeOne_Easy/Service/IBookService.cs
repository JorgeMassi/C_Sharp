using ChallengeOne_Easy.Model;

internal interface IBookService
{
    Book Create(Book myBook);
    Book Retrieve(int id);
    List<Book> RetrieveAll();
    Book Update(Book myBook);
    void Delete(int id);
}