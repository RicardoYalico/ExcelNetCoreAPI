using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.PersonasDomain
{
    public class Personas
    {
        public long IdPersona { get; set; }
        public string tipcontrib { get; set; }
        public string nroruc { get; set; }
        public string desnombre { get; set; }
        public string tippersona { get; set; }
        public DateTime Fecha { get; set; }

    }
}
