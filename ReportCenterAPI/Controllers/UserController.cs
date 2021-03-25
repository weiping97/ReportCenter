using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportCenterAPI.Data;
using ReportCenterAPI.Library.DataAccess;
using ReportCenterAPI.Library.Models;
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
        private readonly IUserData _userData;
        public UserController(ApplicationDbContext context,
            IUserData userData)
        {
            _context = context;
            _userData = userData;
        }

        [HttpGet]
        [Route("GetUser")]
        public UserModel GetById()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return _userData.GetUserById(userId).First();

        }
    }
}
