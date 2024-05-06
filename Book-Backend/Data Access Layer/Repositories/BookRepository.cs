using Data_Access_Layer.Data;
using Data_Access_Layer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repositories
{
    public class BookRepository:IBookRepository
    {
        private readonly FullStackDbContext _dbContext;
        public BookRepository(FullStackDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public BookModel Add_Book(BookModel book)
        {

            _dbContext.Book.AddAsync(book);
            _dbContext.SaveChanges();
            return book;

        }
        public List<BookModel>GetAll()
        {
           var details=_dbContext.Book.ToList();
            return details;
        }
        public BookModel Get(string id)
        {
            if (Guid.TryParse(id, out Guid bookId))
            {
                var details = _dbContext.Book.FirstOrDefault(x => x.Book_Id == bookId);

                // If details is null, it means there is no book with the specified ID
                return details;
            }
            else
            {
                // Handle the case where the provided ID is not a valid GUID
                return null;
            }
        }

    }
}
