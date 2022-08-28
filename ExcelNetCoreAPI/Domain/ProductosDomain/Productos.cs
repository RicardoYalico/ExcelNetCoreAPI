using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.ProductosDomain
{
    public class Productos
    {
        public long IdArtesano { get; set; }
        public long IdItem { get; set; }
        public long IdCategoria { get; set; }
        public string DesCategoria { get; set; }
        public long IdSubCategoria { get; set; }
        public string DesSubCategoria { get; set; }
        public long IdSublinea { get; set; }
        public string DesSublinea { get; set; }
        public string DesProducto { get; set; }
        public float NumPrec { get; set; }
        public string TipProducto { get; set; }
        public long AnioCrea { get; set; }
        public int MesCrea { get; set; }
        public int DiaCrea { get; set; }
        public DateTime Fecha { get; set; }
    }
}
