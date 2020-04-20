using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WSTerceros.Models
{
    public class Persona:Cliente
    {
        public string PrimerApellido { get; set; }
        [StringLength(30)]
        public string SegundoApellido { get; set; }
        [StringLength(30)]
        public string PrimerNombre { get; set; }
        [StringLength(30)]
        public string SegundoNombre { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaExpedicionDocumento { get; set; }
        public string TipoSangre { get; set; }
        public string RH { get; set; }
        public int NumeroHijos { get; set; }
        public string NumeroCertificadoJudicial { get; set; }
        public DateTime FechaVencimientoCertificadoJudicial { get; set; }
        public string NumeroLicencia { get; set; }
        public DateTime FechaVencimientoLicencia { get; set; }
        public string CategoriaLicencia { get; set; }
        public int Codigo_TIDO { get; set; }
        public int Codigo_GENE { get; set; }
        public int Codigo_CIUD { get; set; }
        public int Codigo_ESCI { get; set; }
        public int Codigo_ACEC { get; set; }
        public int Codigo_BARR { get; set; }
        public int Codigo_TIVI { get; set; }
        public DateTime FechaUltimaActualizacion { get; set; }
        public int ExentoParafiscales { get; set; }
        public int Runt { get; set; }
        public int MesExpedicion { get; set; }
    }
}
