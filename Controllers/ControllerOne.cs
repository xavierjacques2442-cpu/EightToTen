using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EightToTen.Services;
using Microsoft.AspNetCore.Http.HttpResults;

namespace EightToTen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerOne : ControllerBase
    {

        private readonly ServiceOne EightBallService;
        public ControllerOne(ServiceOne serviceOne)
        {
            EightBallService = serviceOne;
        }
        [HttpGet("eightball")]
        public ActionResult GetEughtBallResponse([FromQuery] string? question)
        {

        if (string.IsNullOrWhiteSpace(question))
        {
            return Ok(new
            {
                question = "Please ask a yes/no question to receive an eight ball response.",
                example = "/api/controllerone/eightball?question=Will%20I%20be%20lucky%20today?"
            });
        }

    var response = EightBallService.GetRandomResponse();
            return Ok(new
            {
                question = question,
                response = response
            });
}
        }
}
    
