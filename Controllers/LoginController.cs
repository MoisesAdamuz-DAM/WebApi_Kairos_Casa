using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPi_Kairos.Contexts;
using WebAPi_Kairos.Entities;

namespace WebAPi_Kairos.Controllers {
    [ApiController]
    [Route("api/logins")]
    public class LoginController : ControllerBase{

        private readonly ApplicationDbContext context;

        public LoginController(ApplicationDbContext context) {

            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Login>>> Get() {

            return await context.Logins.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult> Post(Login login) {

            context.Add(login);
            context.SaveChanges();
            return Ok();
        }
    }
}
