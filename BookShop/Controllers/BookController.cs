using BookShop.Data;
using BookShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public BookController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item =  _dataContext.Books.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost("/saveBook")]
        public IActionResult SaveBook([FromBody] Book book)
        {
            _dataContext.Books.Add(book);
            _dataContext.SaveChanges();
            return Ok(book);
        }

    }
}
