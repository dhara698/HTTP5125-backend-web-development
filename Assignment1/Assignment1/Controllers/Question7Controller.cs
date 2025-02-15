using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/q7")]
    [ApiController]
    public class Question7Controller : ControllerBase
    {
        /// <summary>
        /// Calculates a date based on the given number of days from today.
        /// </summary>
        /// <param name="days">The number of days to add or subtract from today's date.</param>
        /// <returns>Returns a formatted date string in "yyyy-MM-dd" format.</returns>
        /// <example>
        /// Request: GET /api/q7/timemachine?days=5  
        /// Response: "2025-02-13" (if today is "2025-02-08")
        /// 
        /// Request: GET /api/q7/timemachine?days=-5  
        /// Response: "2025-02-03" (if today is "2025-02-08")
        /// </example>

        [HttpGet(template: "timemachine")]
        public string Date([FromQuery] int days)
        {
            // Get today's date
            DateTime dateTime = DateTime.Today;

            // Add (or subtract) the specified number of days
            DateTime answer = dateTime.AddDays(days);

            // Return the new date in "yyyy-MM-dd" format
            return answer.ToString("yyyy-MM-dd");
        }

    }
}  