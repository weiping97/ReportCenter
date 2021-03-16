using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportCenterAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ReportCenterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("testing")]
        public IActionResult GetById()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //db get data
            return Ok("test good");
        }
    }
}
