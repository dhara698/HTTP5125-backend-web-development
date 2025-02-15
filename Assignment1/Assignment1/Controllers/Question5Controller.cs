using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/q5")]
    [ApiController]
    public class Question5Controller : ControllerBase
    {
        /// <summary>
        /// Receives a secret number and returns a message with the secret.
        /// </summary>
        /// <param name="secret">An integer value representing the secret.</param>
        /// <returns>Returns a string message revealing the secret.</returns>
        /// <example>
        /// Request: POST /api/q5/secret  
        /// Body: { "secret": 123 }  
        /// Response: "Shh.. the secret is 123"
        /// </example>

        [HttpPost(template:"secret")]
        public string PostSecret([FromBody]int secret)
        {
            // Concatenates the given secret number into a string message
            return "Shh.. the secret is " + secret;
        }
    }
}
