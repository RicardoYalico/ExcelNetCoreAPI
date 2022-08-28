using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.SubcategoriasDomain
{
    public interface ISubCategoriasRepository
    {
        Task<IEnumerable<SubCategorias>> GetAllAsync();

        Task<IEnumerable<SubCategorias>> GetByDateRange(DateTime firstDate, DateTime secondDate);
    }
}
