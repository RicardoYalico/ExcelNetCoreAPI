using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.PersonasDomain
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonasController : Controller
    {
        private readonly IPersonasRepository _personasRepository;
        public PersonasController(IPersonasRepository personasRepository)
        {
            _personasRepository = personasRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _personasRepository.GetAllAsync());
        }

        [HttpGet("inicio={start}/final={end}")]
        public async Task<IActionResult> GetDateInRange(string start, string end)
        {
            return Ok(await _personasRepository.GetByDateRange(DateTime.Parse(start), DateTime.Parse(end)));
        }
    }
}
