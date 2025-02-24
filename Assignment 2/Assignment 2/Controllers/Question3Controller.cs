﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers
{
    [Route("api/J2")]
    [ApiController]
    public class Question3Controller : ControllerBase
    {
        
        /// <summary>
        /// Calculates the total Scoville Heat Units (SHU) for a list of chili pepper ingredients.
        /// </summary>
        /// <param name="Ingredients">A comma-separated list of chili pepper names.</param>
        /// <returns>The total SHU for the given ingredients.</returns>
        /// <example>
        /// GET /api/J2/ChiliPeppers?Ingredients=Poblano,Cayenne,Thai,Poblano
        /// 
        /// Result: 118000
        /// </example>
        [HttpGet(template: "ChiliPeppers")]
        public int GetSHU([FromQuery] string Ingredients)
        {
            int totalSHU = 0;
            Dictionary<string, int> pepperSHU = new Dictionary<string, int>()
            {
                {"Poblano", 1500},
                {"Mirasol", 6000},
                {"Serrano", 15500},
                {"Cayenne", 40000},
                {"Thai", 75000},
                {"Habanero", 125000}
            };

            string[] ingredients = Ingredients.Split(',');
            for (int i = 0; i < ingredients.Length; i++)
            {
                string ingredient = ingredients[i].Trim();
                if (pepperSHU.ContainsKey(ingredient))
                {
                    totalSHU += pepperSHU[ingredient];
                }
            }
            return totalSHU;
        }
    }
}
    

