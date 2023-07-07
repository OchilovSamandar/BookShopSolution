using BookShop.Data;
using BookShop.Dto;
using BookShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    [Route("api/role")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public RoleController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost("/save")]
        public IActionResult SaveRole([FromBody] Role roleDto)
        {
            if (roleDto == null)
            {
                return BadRequest("null keldi");
            }

            _dataContext.Roles.Add(roleDto);
            _dataContext.SaveChanges();
            return Ok("Saqlandi");
        }
    }
}
