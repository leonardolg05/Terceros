using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WSTerceros.Models
{
    public class Empresa:Cliente
    {
        public string Nombre { get; set; }
        public string NombreRepresentanteLegal { get; set; }
        public string IdentificacionRepresentanteLegal { get; set; }
    }
}
