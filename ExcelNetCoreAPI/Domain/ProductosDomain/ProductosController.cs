using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.ProductosDomain
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : Controller
    {
        private readonly IProductosRepository _productosRepository;
        public ProductosController(IProductosRepository productosRepository)
        {
            _productosRepository = productosRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok(await _productosRepository.GetCategorias());
        }

        [HttpGet("inicio={start}/final={end}")]
        public async Task<IActionResult> GetDateInRange(string start, string end)
        {
            return Ok(await _productosRepository.GetByDateRange(DateTime.Parse(start), DateTime.Parse(end)));
        }
    }
}
