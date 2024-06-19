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
        public User GetUser()
        {
            oUsuarios users = new oUsuarios(_context);
            var user = users.GetUser();

            if (user == null)
            {
                return new User();
            }

            return user;
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public User GetUser(int id)
        {
            oUsuarios users = new oUsuarios(_context);
            var user =  users.GetUser(id);

            if (user == null)
            {
                return new User();
            }

            return user;
        }

    }
}
