using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.ProductosDomain
{
    public interface IProductosRepository
    {
        Task<IEnumerable<Productos>> GetCategorias();

        Task<IEnumerable<Productos>> GetByDateRange(DateTime firstDate, DateTime secondDate);
    }
}
