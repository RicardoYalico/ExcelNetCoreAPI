using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.ArtesanosDomain
{
    public interface IArtesanosRepository
    {
        Task<IEnumerable<Artesanos>> GetAllAsync();

        Task<IEnumerable<Artesanos>> GetByDateRange(DateTime firstDate, DateTime secondDate);
    }
}
