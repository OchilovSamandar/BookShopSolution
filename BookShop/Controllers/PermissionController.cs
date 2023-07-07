using BookShop.Data;
using BookShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Controllers
{
    [Route("api/permission")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PermissionController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost("/save")]
        public IActionResult Save([FromBody] Permission permission)
        {
            if (permission == null)
            {
                return BadRequest("permission null keldi");
            }
            permission.Id = 0;// _dataContext.Entry(permission).State = EntityState.Added;

            _dataContext.Permissions.Add(permission);
            _dataContext.SaveChanges();
            return Ok("Saved");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Permission? permission  = _dataContext.Permissions.FirstOrDefault(i => i.Id == id);
            if (permission == null)
            {
                return NotFound();
            }
            return Ok(permission);
        }

    }
}
