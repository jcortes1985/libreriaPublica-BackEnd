using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using libreria_data;
using libreria_publica_Data.Models.security;
using libreria_business.businessObjects;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace libreria_srv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public UsersController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        //[Authorize]
        public List<User> GetUser()
        {
            oUsuarios users = new oUsuarios(_context);
            var user = users.GetUser();

            if (user == null)
            {
                return new List<User>();
            }

            return user; 
        }

        // POST: api/Users/5
        [HttpPost]
        //[Authorize]
        //[Route("GetUser/{email},{password}")]
        public List<User> GetUser(string email, string password)
        {
            oUsuarios users = new oUsuarios(_context);
            var user =  users.GetUser(email, password);

            if (user.Count() == 0)
            {
                return new List<User>();
            }

            return user;
        }

    }
}
