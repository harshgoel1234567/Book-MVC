using Data_Access_Layer.Entity;
using Data_Access_Layer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Services
{
    public class BookService:IBookService
    {
        public readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public BookModel Add_Book(BookModel book)
        {
            return _repository.Add_Book(book);
            

        }
        public List<BookModel> GetAll()
        {
            return _repository.GetAll();
        }
        public BookModel Get(string id)
        {
            return _repository.Get(id);
        }
    }
}
