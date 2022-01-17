using System;
using Microsoft.AspNetCore.Mvc;

namespace FoodApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class FoodController : ControllerBase
    {
        private static readonly string[] _foodItems = new[]
        {
            "Pizza","Pasta","Burger","Ice cream","Pastry","Chocolate"
        };
        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();
            return Ok(_foodItems[rng.Next(_foodItems.Length)]);
        }
    }
}