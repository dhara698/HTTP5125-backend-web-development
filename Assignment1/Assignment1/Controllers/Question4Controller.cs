using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/q4")]
    [ApiController]
    public class Question4Controller : ControllerBase
    {
        /// <summary>
        /// Responds to a "Knock Knock" request with "Who's there?".
        /// </summary>
        /// <returns>Returns the string "Who's there?".</returns>
        /// <example>
        /// Request: POST /api/q4/knockknock  
        /// Response: "Who's there?"
        /// </example>

        [HttpPost(template:"knockknock")]
        public string KnockKnock()
        {
            // Returns the "Knock Knock" response
            return "Who's there?";
        }
    }
}
