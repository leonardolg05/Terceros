namespace WSTerceros.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using WSTerceros.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public EmpresaController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [Route("ConsultarEmpresas")]
        [HttpPost()]
        public IActionResult ConsultarEmpresas()
        {
            return Ok(context.tblEmpresa);
        }
        [Route("CrearEmpresa")]
        [HttpPost]
        public IActionResult CrearEmpresa([FromBody] Empresa empresa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.tblEmpresa.Add(empresa);
            context.SaveChanges();

            return new CreatedAtRouteResult("empresaCreada", new { id = empresa.Id });
        }


        [Route("ActualizarEmpresa")]
        [HttpPost]
        public IActionResult ActualizarEmpresa([FromBody] Empresa empresa)
        {
            if (empresa.Id == 0)
            {
                return BadRequest();
            }
            var datosEmpresa = context.tblEmpresa.First(x => x.Id == empresa.Id);
            datosEmpresa.Id = empresa.Id;
            if (datosEmpresa != null)
            {
                context.Entry(datosEmpresa).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(datosEmpresa);
            }
            else
            {
                return BadRequest();
            }
        }
        [Route("EliminarEmpresa")]
        [HttpPost]
        public IActionResult EliminarEmpresa([FromBody] Empresa empresa)
        {
            var idEmpresa = context.tblEmpresa.FirstOrDefault(x => x.Id == empresa.Id);
            if (idEmpresa == null)
            {
                return NotFound();
            }
            context.tblEmpresa.Remove(empresa);
            context.SaveChanges();
            return Ok(empresa);
        }
    }
}