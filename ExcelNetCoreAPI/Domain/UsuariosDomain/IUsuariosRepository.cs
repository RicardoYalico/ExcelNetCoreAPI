using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.UsuariosDomain
{
    public interface IUsuariosRepository
    {
        Task<IEnumerable<Usuarios>> GetAllAsync();

        Task<IEnumerable<Usuarios>> GetByDateRange(DateTime firstDate, DateTime secondDate);
    }
}
