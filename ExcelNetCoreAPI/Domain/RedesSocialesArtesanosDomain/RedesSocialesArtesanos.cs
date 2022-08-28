using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.RedesSocialesArtesanosDomain
{
    public class RedesSocialesArtesanos
    {
        public long IdArtesano { get; set; }
        public long IdRedSocial { get; set; }
        public string DesPersona { get; set; }
        public string DesRedSocial { get; set; }
        public long IdPersona { get; set; }
        public DateTime Fecha { get; set; }
    }
}
