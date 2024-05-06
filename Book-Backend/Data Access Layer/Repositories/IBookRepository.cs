using Data_Access_Layer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repositories
{
    public interface IBookRepository
    {
        public BookModel Add_Book(BookModel book);
        public List<BookModel> GetAll();
        public BookModel Get(string id);
    }
}
