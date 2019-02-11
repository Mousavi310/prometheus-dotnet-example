using System;
using Microsoft.AspNetCore.Mvc;

namespace src.Controllers
{
    [Route("api")]
    public class OrdersController : ControllerBase
    {
        [HttpGet("orders")]
        public IActionResult GetAllAsync()
        {
            if(new Random().Next(2) == 1)
            {
                return BadRequest("bad request");
            }

            return Ok("ok");
        } 

        [HttpGet("orders/{id}")]
        public IActionResult GetAllAsync(int id)
        {
            if(new Random().Next(10) == 1)
            {
                return BadRequest("bad request");
            }

            return Ok("ok");
        } 
    }
}