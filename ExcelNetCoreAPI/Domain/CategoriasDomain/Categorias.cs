using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain
{
    public class Categorias
    {
        public long IdCategoria { get; set; }
        public string DesCategoria { get; set; }
        public DateTime Fecha { get; set; }
    }
}
