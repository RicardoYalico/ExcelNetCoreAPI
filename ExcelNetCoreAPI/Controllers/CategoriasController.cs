using ExcelNetCoreAPI.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : Controller
    {
        private readonly ICategoriasRepository _categoriasRepository;
        public CategoriasController(ICategoriasRepository categoriasRepository)
        {
            _categoriasRepository = categoriasRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok(await _categoriasRepository.GetCategorias());
        }

        [HttpGet("inicio={start}/final={end}")]
        public async Task<IActionResult> GetDateInRange(string start, string end)
        {
            return Ok(await _categoriasRepository.GetByDateRange(DateTime.Parse(start), DateTime.Parse(end)));
        }
    }
}
