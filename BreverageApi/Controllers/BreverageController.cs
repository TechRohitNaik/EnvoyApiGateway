using System;
using Microsoft.AspNetCore.Mvc;

namespace BreverageApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class BreverageController : ControllerBase
    {
        private static readonly string[] _brevItems = new[]
        {
            "Lamonade","Coffee","Team","Cold Drink","Butter Milk","HotChocolate"
        };
        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();
            return Ok(_brevItems[rng.Next(_brevItems.Length)]);
        }
    }
}