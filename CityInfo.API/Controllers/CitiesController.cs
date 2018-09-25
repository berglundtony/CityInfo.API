using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        //GET api/cities
        /// <summary>
        /// This shows the list of all the cities and the information including points of views information.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCities()
        {
            //return new JsonResult(new List<object>()
            //{
            //    new { id=1, Name="New York City" },
            //    new { id=2, Name="Antwerp"},
            //    new { id=3, Name="Stockholm"}
            //});
            return Ok(CityDataStore.Current.Cities);
        }
        //GET api/cities
        /// <summary>
        /// This will provide information about a specific city.
        /// </summary>
        /// <param name="id">Mandatory</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var cityToReturn = CityDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if(cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
        }

    }
}