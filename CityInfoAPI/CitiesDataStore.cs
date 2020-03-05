using System.Collections.Generic;

using CityInfoAPI.Models;

namespace CityInfoAPI
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }



        public CitiesDataStore()
        {
            //init dommy data

            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    id = 1,
                    Name = "New York City",
                    Description ="The one with that big park."
                },
                new CityDto()
                {
                    id = 2,
                    Name = "Antwerp",
                    Description = "The one in a horror movie"
                },
                new CityDto()
                {
                    id = 3,
                    Name = "Paris",
                    Description = "The one at the center of it all"
                }
            };
        }
    }
}
