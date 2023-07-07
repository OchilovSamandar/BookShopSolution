using BookShop.Data;
using BookShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public UserController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public IActionResult SaveUser([FromBody] User user)
        {
            _dataContext.Users.Add(user);
            _dataContext.SaveChanges();
            return Ok("Saved");

        }
    }
}
