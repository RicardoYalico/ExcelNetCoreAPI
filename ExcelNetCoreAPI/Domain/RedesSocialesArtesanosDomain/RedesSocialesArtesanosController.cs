using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain.RedesSocialesArtesanosDomain
{
    [ApiController]
    [Route("api/[controller]")]
    public class RedesSocialesArtesanosController : Controller
    {
        private readonly IRedesSocialesArtesanosRepository _redesSocialesArtesanosRepository;
        public RedesSocialesArtesanosController(IRedesSocialesArtesanosRepository redesSocialesArtesanosRepository)
        {
            _redesSocialesArtesanosRepository = redesSocialesArtesanosRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _redesSocialesArtesanosRepository.GetAllAsync());
        }

        [HttpGet("inicio={start}/final={end}")]
        public async Task<IActionResult> GetDateInRange(string start, string end)
        {
            return Ok(await _redesSocialesArtesanosRepository.GetByDateRange(DateTime.Parse(start), DateTime.Parse(end)));
        }
    }
}
