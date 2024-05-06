using Business_Layer.Services;
using Data_Access_Layer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Book_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        public readonly IBookService BookService;
        public BookController(IBookService _BookService)
        {
            BookService =_BookService;
        }
        [HttpPost]
        public IActionResult Add_Book(BookModel model)
        {
            BookService.Add_Book(model);
            return Ok(model);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var e=BookService.GetAll();
            return Ok(e);
        }
        [HttpGet]
        public IActionResult Get(string id)
        {
            var e = BookService.Get(id);
            return Ok(e);
        }
    }
}
