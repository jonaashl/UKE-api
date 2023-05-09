using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UKE_api.Data;
using UKE_api.Models;

namespace UKE_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversionHistoryController : ControllerBase
    {
        private readonly NumeralDbContext _context;

        public ConversionHistoryController(NumeralDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddConversionToHistory(ConversionHistory conversion)
        {
            conversion.ConversionTime = DateTime.Now;
            _context.ConversionHistory.Add(conversion);
            _context.SaveChanges();

            return Ok();
        }

        [HttpGet]
        public IActionResult GetConversionHistory()
        {
            var conversionHistory = _context.ConversionHistory.ToList();

            return Ok(conversionHistory);
        }
    }
}