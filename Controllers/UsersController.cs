using EreminAPI1.Classes.Entityes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EreminAPI1.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsersController:ControllerBase
    {
        [HttpGet]
        public List<User> GetUsers()
        {
            return Classes.Entityes.User.Select();
        }
    }
}
