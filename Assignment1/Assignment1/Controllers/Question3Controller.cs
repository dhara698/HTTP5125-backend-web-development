using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/q3")]
    [ApiController]
    public class Question3Controller : ControllerBase
    {
        /// <summary>
        /// Calculates the cube of a given number.
        /// </summary>
        /// <param name="baseNumber">The number to be cubed.</param>
        /// <returns>Returns the cube of the given number.</returns>
        /// <example>
        /// Request: GET /api/q3/cube/3  
        /// Response: 27  
        /// 
        /// Request: GET /api/q3/cube/4  
        /// Response: 64  
        /// </example>

        [HttpGet(template:"cube/{baseNumber}")]
        public int cube(int baseNumber)
        {
            // Calculate the cube of the given number
            return (baseNumber * baseNumber * baseNumber);
        }
    }
}
