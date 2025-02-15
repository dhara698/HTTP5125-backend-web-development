using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/q1")]
    [ApiController]
    public class Question1Controller : ControllerBase
    {
        /// <summary>
        /// Returns a welcome message.
        /// </summary>
        /// <returns>Returns a string message: "Welcome to 5125!"</returns>
        /// <example>
        /// Request: GET /api/q1/welcome  
        /// Response: "Welcome to 5125!"
        /// </example>

        [HttpGet(template:"welcome")]
        public string getWelcomeMessage()
        {
            // Returns a simple welcome message
            return "Welcome to 5125!";
        }
    }
}
