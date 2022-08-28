using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.PersonasDomain
{
    public interface IPersonasRepository
    {
        Task<IEnumerable<Personas>> GetAllAsync();

        Task<IEnumerable<Personas>> GetByDateRange(DateTime firstDate, DateTime secondDate);
    }
}
