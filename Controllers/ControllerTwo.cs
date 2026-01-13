using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EightToTen.Services;

namespace EightToTen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerTwo : ControllerBase
    {
        private readonly serviceTwo _serviceTwo;

        public ControllerTwo(serviceTwo serviceTwo)
        {
            _serviceTwo = serviceTwo;
        }
       
        [HttpGet("easy")]
        public IActionResult Easy([FromQuery] int number)
        {
            if (number < 1 || number > 10)
            {
                return BadRequest("Number must be between 1 and 10.");
            }
            return Ok(_serviceTwo.Guess(number, 10));
        }
        
        [HttpGet("middle")]
        public IActionResult Middle([FromQuery] int number)
        {
            if (number < 1 || number > 50)
            {
                return BadRequest("Number must be between 1 and 50.");
            }
            return Ok(_serviceTwo.Guess(number, 50));
           
        }

        [HttpGet("hard")]
        public IActionResult Hard([FromQuery] int number)
        {
            if (number < 1 || number > 100)
            {
                return BadRequest("Number must be between 1 and 100.");
            }
            return Ok(_serviceTwo.Guess(number, 100));
    }
    }
}