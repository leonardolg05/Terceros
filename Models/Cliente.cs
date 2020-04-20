using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSTerceros.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public int Identificacion { get; set; }
        public string TipoCliente { get; set; }
        public string TelefonoCelular { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Telefono3 { get; set; }
        public string Direccion { get; set; }
        public string DireccionCorrespondencia { get; set; }
        public int IdMubicipio { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Email { get; set; }

    }
}
