using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UKE_api.Data;
using UKE_api.Models;

namespace UKE_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RomanNumeralController : ControllerBase
    {
        private readonly Dictionary<char, int> numeralDictionary = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        private readonly NumeralDbContext _context;

        public RomanNumeralController(NumeralDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Convert([FromBody] RomanNumeralModel model)
        {
            string numeral = model.Numeral;

            if (string.IsNullOrEmpty(numeral))
            {
                return BadRequest("Roman numeral cannot be null or empty.");
            }

            var prevValue = 0;
            var result = 0;

            foreach (var c in numeral.ToUpper().ToCharArray())
            {
                if (!numeralDictionary.ContainsKey(c))
                {
                    return BadRequest("Invalid Roman numeral.");
                }

                var currentValue = numeralDictionary[c];

                if (currentValue > prevValue)
                {
                    result += currentValue - 2 * prevValue;
                }
                else
                {
                    result += currentValue;
                }

                prevValue = currentValue;
            }

            var conversionHistory = new ConversionHistory
            {
                RomanNumeral = numeral,
                NormalNumber = result,
                ConversionTime = DateTime.Now
            };

            _context.ConversionHistory.Add(conversionHistory);
            _context.SaveChanges();


            return Ok(result);

        }
    }
}
