using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

namespace CityInfoAPI.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {

        public JsonResult GetCities()
        {

            return new JsonResult(new List<object>() { new { id = 1, Name = "New York CIty" }, new { id = 2, Name = "Antwar" } });
        }
    }
}
