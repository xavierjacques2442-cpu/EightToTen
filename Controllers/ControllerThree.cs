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
    public class ControllerThree : ControllerBase
    {
    private readonly serviceThree _serviceThree;

public ControllerThree(serviceThree serviceThree)
{
    _serviceThree = serviceThree;
}
        [HttpGet("pick")]
public IActionResult Pick([FromQuery] string cuisinePicker)
        {
        if (string.IsNullOrWhiteSpace(cuisinePicker))
        {
            return Ok(new
            {
                question = "Please provide a cuisine type to pick from.",
                choices = _serviceThree.GetCategories(),
                example = "/api/controllerthree/pick?cuisinePicker=Italian"
            });
        }

            try
            {   
        var restaurant = _serviceThree.Pick(cuisinePicker);
                return Ok(new
                {
                    category = cuisinePicker,
                    restaurant = restaurant
                });
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
}
    }
}
