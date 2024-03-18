using FirstWebApi.Core;
using FirstWebApi.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.MainWeb.Controllers
{
    [Route("/api/user")]
    public class UserController : Controller
    {
        private readonly FirstWebApiDbContext _context;

        public UserController(FirstWebApiDbContext context) 
        { 
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _context.Users.ToList();

            return Ok(users);
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return Created("", user);
        }
    }
}
