using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPi_Kairos.Contexts;
using WebAPi_Kairos.Entities;

namespace WebAPi_Kairos.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase{

        private readonly ApplicationDbContext context;

        public PersonaController(ApplicationDbContext context) {

            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Persona>> Get() {

            return context.Personas.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Persona> Get(int id) {

            var persona = context.Personas.FirstOrDefault(x => x.Id == id);

            if(persona == null) {

                return NotFound();
            }

            return persona;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Persona persona) {

            context.Personas.Add(persona);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerPersona", new { id = persona.Id }, persona);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Persona value) {

            if(id != value.Id) {

                return BadRequest();
            }

            context.Entry(value).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Persona> Delete(int id) {

            var persona = context.Personas.FirstOrDefault(x => x.Id == id);

            if(persona == null) {

                return NotFound();
            }

            context.Personas.Remove(persona);
            context.SaveChanges();
            return persona;
        }
    }
}
