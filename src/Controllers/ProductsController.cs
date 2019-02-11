using System;
using Microsoft.AspNetCore.Mvc;

namespace prometheus_dotnet_example.Controllers
{
    [Route("api")]
    public class ProductsController : ControllerBase
    {
        [HttpGet("products")]
        public IActionResult GetAllAsync()
        {
            if(new Random().Next(3) == 1)
            {
                return BadRequest("bad request");
            }

            return Ok("ok");
        } 

        [HttpGet("products/{id}")]
        public IActionResult GetAllAsync(int id)
        {
            if(new Random().Next(4) == 1)
            {
                return BadRequest("bad request");
            }

            return Ok("ok");
        } 
    }
}