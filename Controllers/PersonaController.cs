using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WSTerceros.Models;

namespace WSTerceros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public PersonaController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [Route("ConsultarPersonas")]
        [HttpPost()]
        public IActionResult ConsultarPersonas()
        {
            return Ok(context.tblPersona);
        }

        [Route("ConsultarPersonaCedula")]
        [HttpPost]
        public IActionResult ConsultarPersonaCedula([FromBody] Persona persona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var personaIdentificada = context.tblPersona.FirstOrDefault(identificacionPersona => identificacionPersona.Identificacion == persona.Identificacion);
            context.SaveChanges();

            return new CreatedAtRouteResult("personaIdentificada", new { personaIdentificada });
        }

        [Route("CrearPersona")]
        [HttpPost]
        public IActionResult CrearPersona([FromBody] Persona persona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.tblPersona.Add(persona);
            context.SaveChanges();

            return new CreatedAtRouteResult("personaCreada", new { id = persona.Id });
        }

        [Route("ActualizarPersona")]
        [HttpPost]
        public IActionResult ActualizarPersona([FromBody] Persona persona)
        {
            if (persona.Id == 0)
            {
                return BadRequest();
            }
            var datosPersona = context.tblPersona.First(x => x.Id == persona.Id);
            datosPersona.Id = persona.Id;
            if (datosPersona != null)
            {
               context.Entry(datosPersona).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(datosPersona);
            }
            else
            {
                return BadRequest();
            }
        }

        [Route("EliminarPersona")]
        [HttpPost]
        public IActionResult EliminarPersona([FromBody] Persona persona)
        {
            var idPersona = context.tblPersona.FirstOrDefault(x => x.Id == persona.Id);
            if (idPersona == null)
            {
                return NotFound();
            }
            context.tblPersona.Remove(persona);
            context.SaveChanges();
            return Ok(persona);
        }
    }
}