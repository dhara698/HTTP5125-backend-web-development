using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    // Defines the route prefix for the controller as "api/q6"
    [Route("api/q6")]
    [ApiController]
    public class Question6Controller : ControllerBase
    {
        /// <summary>
        /// Calculates the area of a hexagon based on the given side length.
        /// </summary>
        /// <param name="side">The length of one side of the hexagon.</param>
        /// <returns>Returns the computed area of the hexagon as a double.</returns>
        /// <example>
        /// Request: GET /api/q6/hexagon?side=5  
        /// Response: 64.9519052838329  
        /// 
        /// Request: GET /api/q6/hexagon?side=10  
        /// Response: 259.8076211353316  
        /// </example>

        [HttpGet(template:"hexagon")]

        public double GetArea([FromQuery] double side)
        {
            // Formula for the area of a hexagon: (3 * sqrt(3) / 2) * side^2
            double area = 3 * Math.Sqrt(3) / 2 * side * side;
            // Return the computed area of the hexagon
            return area;
        }
    }
}
