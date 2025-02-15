using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/q2")]
    [ApiController]
    public class Question2Controller : ControllerBase
    {
        /// <summary>
        /// Returns a personalized greeting message.
        /// </summary>
        /// <param name="name">The name to be included in the greeting.</param>
        /// <returns>Returns a greeting message including the provided name.</returns>
        /// <example>
        /// Request: GET /api/q2/greeting?name=John  
        /// Response: "Hi John!"  
        /// 
        /// Request: GET /api/q2/greeting?name=Alice  
        /// Response: "Hi Alice!"
        /// </example>

        [HttpGet(template:"greeting")]
        public string greetingName(string name)
        {
            // Returns a personalized greeting message
            return $"Hi {name}!";
        }
    }
}
