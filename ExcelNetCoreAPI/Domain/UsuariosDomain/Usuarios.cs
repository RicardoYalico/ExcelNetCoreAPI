using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.UsuariosDomain
{
    public class Usuarios
    {
        public long IdUsuario { get; set; }
        public string TipUsuario { get; set; }
        public string DesNombre { get; set; }
        public string Correo { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public long AnioNac { get; set; }
        public int MesNac { get; set; }
        public int DiaNac { get; set; }
        public int AnioCrea { get; set; }
        public int MesCrea { get; set; }
        public int DiaCrea { get; set; }
        public DateTime Fecha { get; set; }
    }
}
