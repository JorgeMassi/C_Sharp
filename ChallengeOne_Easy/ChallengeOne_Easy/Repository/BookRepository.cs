using System;
using ChallengeOne_Easy.Model;

namespace ChallengeOne_Easy.Repository
{
    internal class BookRepository : IBookRepository
    {
        private static Book[] _myBook = new Book[0];

        private static int _id = 1;

        public Book Create(Book myBook)
        {

            myBook.id = _id;
            _id++;
            Array.Resize(ref _myBook, _myBook.Length + 1);
            _myBook[_myBook.Length - 1] = myBook;
            return myBook;

        }

        public Book Retrieve(int id)
        {

            foreach (Book myBook in _myBook)
            {
                
                if (myBook.id.Equals(id))
                {
                    return myBook;
                }
            }
            throw new KeyNotFoundException("Book Id: " + id + " not found.");
        }

        public List<Book>  RetrieveAll()
        {
            List<Book> myBookList = new List<Book>();
            for (int i = 0; i < _myBook.Length; i++)
            {
                myBookList.Add(_myBook[i]);
            }
            return myBookList;
        }

        public Book Update(Book myBookToUpdate)
        {
            foreach (Book myBook in _myBook)
            {
                
                if (myBook.id.Equals(myBookToUpdate.id))
                {
                    myBook.title = myBookToUpdate.title;
                    myBook.description = myBookToUpdate.description;
                    myBook.isbn = myBookToUpdate.isbn;
                }
            }
            return myBookToUpdate;
        }

        public void Delete(int id)
        {
            Book bookToDelete = Retrieve(id);

            List<Book> resizeList = _myBook.ToList();
            resizeList.Remove(bookToDelete);
            _myBook = resizeList.ToArray();
        }
    }
}
