
using Microsoft.AspNetCore.Mvc;

namespace CityInfoAPI.Controllers
{
    [ApiController]
    [Route("api/cities")]

    public class CitiesController : ControllerBase
    {
        public JsonResult GetCities()
        {

            return new JsonResult(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var result = CitiesDataStore.Current.Cities.Find(x => x.id == id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);

        }
    }
}
