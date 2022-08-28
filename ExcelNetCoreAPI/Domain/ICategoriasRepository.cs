using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain
{
    public interface ICategoriasRepository
    {
        Task<IEnumerable<Categorias>> GetCategorias();

        Task<IEnumerable<Categorias>> GetByDateRange(DateTime firstDate, DateTime secondDate);

    }
}
