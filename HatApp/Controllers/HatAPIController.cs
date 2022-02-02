using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HatApp.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class HatAPIController
    {
        DAL db = new DAL();

        [HttpGet("hats")]
        public List<Hats> GetHats()
        {
            return db.AllHats();
        }

        [HttpGet("users")]
        public List<Users> GetUsers()
        {
            return db.AllUser();
        }

    }
}
