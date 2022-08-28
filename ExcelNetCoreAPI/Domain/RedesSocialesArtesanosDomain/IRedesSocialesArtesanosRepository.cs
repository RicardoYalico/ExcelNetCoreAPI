using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.RedesSocialesArtesanosDomain
{
    public interface IRedesSocialesArtesanosRepository
    {
        Task<IEnumerable<RedesSocialesArtesanos>> GetAllAsync();

        Task<IEnumerable<RedesSocialesArtesanos>> GetByDateRange(DateTime firstDate, DateTime secondDate);
    }
}
