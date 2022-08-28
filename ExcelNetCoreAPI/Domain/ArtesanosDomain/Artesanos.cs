using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.ArtesanosDomain
{
    public class Artesanos
    {
        public long IdArtesano { get; set; }
        public long IdPersona { get; set; }
        public string DesPersona { get; set; }
        public string IndItems { get; set; }
        public string IndActivo { get; set; }
        public string DesDepa { get; set; }
        public string DesProv { get; set; }
        public string DesDist { get; set; }
        public long CodUbigeoAsumido { get; set; }
        public long AnioCrea { get; set; }
        public int MesCrea { get; set; }
        public int DiaCrea { get; set; }
        public DateTime Fecha { get; set; }
    }
}
