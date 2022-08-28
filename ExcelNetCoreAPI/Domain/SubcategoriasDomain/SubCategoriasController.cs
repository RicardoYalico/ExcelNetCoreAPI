using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.SubcategoriasDomain
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubCategoriasController : Controller
    {

        private readonly ISubCategoriasRepository _subCategoriasRepository;
        public SubCategoriasController(ISubCategoriasRepository subCategoriasRepository)
        {
            _subCategoriasRepository = subCategoriasRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _subCategoriasRepository.GetAllAsync());
        }

        [HttpGet("inicio={start}/final={end}")]
        public async Task<IActionResult> GetDateInRange(string start, string end)
        {
            return Ok(await _subCategoriasRepository.GetByDateRange(DateTime.Parse(start), DateTime.Parse(end)));
        }
    }
}
