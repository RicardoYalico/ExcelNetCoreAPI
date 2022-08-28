using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.PersonasDomain
{
    public class Personas
    {
        public long IdPersona { get; set; }
        public string TipContrib { get; set; }
        public string NroRuc { get; set; }
        public string DesNombre { get; set; }
        public string TipPersona { get; set; }
        public DateTime Fecha { get; set; }

    }
}
