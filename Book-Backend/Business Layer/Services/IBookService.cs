using Data_Access_Layer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Services
{
    public interface IBookService
    {
        public BookModel Add_Book(BookModel Book);
        public List<BookModel> GetAll();
        public BookModel Get(string id);
       
    }
}
