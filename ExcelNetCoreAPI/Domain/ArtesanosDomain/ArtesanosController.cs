using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.ArtesanosDomain
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtesanosController : Controller
    {
        private readonly IArtesanosRepository _artesanosRepository;
        public ArtesanosController(IArtesanosRepository artesanosRepository)
        {
            _artesanosRepository = artesanosRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _artesanosRepository.GetAllAsync());
        }

        [HttpGet("inicio={start}/final={end}")]
        public async Task<IActionResult> GetDateInRange(string start, string end)
        {
            return Ok(await _artesanosRepository.GetByDateRange(DateTime.Parse(start), DateTime.Parse(end)));
        }
    }
}
