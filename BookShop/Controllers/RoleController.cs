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

        [HttpPost]
        public IActionResult SaveRole([FromBody] RoleDto roleDto)
        {
            if (roleDto == null)
            {
                return BadRequest("null keldi");
            }
            var role = new Role
            {
                Name = roleDto.Name,
                Description = roleDto.Description,

            };

            _dataContext.Roles.Add(role);
            _dataContext.SaveChanges();
            return Ok("Saqlandi");
        }
    }
}
