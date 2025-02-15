using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    [Route("api/q8")]
    [ApiController]
    public class Question8Controller : ControllerBase
    {
        /// <summary>
        /// Build an online store which sells SquashFellows plushies.
        /// </summary>
        /// <param name="Small">The number of small SquashFellows plushies</param>
        /// <param name="Large">The number of large SquashFellows plushies</param>
        /// <returns>Returns a formatted string with the total price, tax, and grand total</returns>
        /// <example>
        /// Request Body: Small=1 & Large=1 / Small=2 & Large=1 / Small=100 & Large=100
        /// 
        /// Result: "1 Small @ $25.50 = $25.50; 1 Large @ $40.50 = $40.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58"
        /// 
        /// Result: "2 Small @ $25.50 = $51.00; 1 Large @ $40.50 = $40.50; Subtotal = $91.50; Tax = $11.90 HST; Total = $103.40"
        /// 
        /// Result: "100 Small @ $25.50 = $2550.00; 100 Large @ $40.50 = $4050.00; Subtotal = $6600.00; Tax = $858.00 HST; Total = $7458.00"
        /// </example>
        [HttpPost (template:"Squashfellows")]
        [Consumes("application/x-www-form-urlencoded")]
        public string Squashfellows([FromForm] int Small, [FromForm] int Large)
        {
            //Constants: Prices and Tax rate
            decimal Small_Price = 25.50m;
            decimal Large_Price = 40.50m;
            decimal HST = 0.13m;

            //Step:1 Calculate total price before tax
            decimal SmallTotal = Small * Small_Price;
            decimal LargeTotal = Large * Large_Price;
            decimal SubTotal = SmallTotal + LargeTotal;

            //Step:2 Calculate tax amount (round to 2 decimal places)
            decimal Tax = Math.Round(SubTotal * HST, 2,MidpointRounding.AwayFromZero);
            
            //Step:3 Calculate final total (Subtotal + Tax)
            decimal Total = Math.Round(SubTotal + Tax , 2,MidpointRounding.AwayFromZero);

            //Step:4 Format output as a readable summary
            string Final_output = $"{Small} Small @ ${Small_Price:F2} = ${SmallTotal:F2};" + 
                                  $"{Large} Large @ ${Large_Price:F2} = ${LargeTotal:F2};" + 
                                  $"SubTotal = ${SubTotal:F2};" + 
                                  $"Tax = ${Tax:F2} HST;" +
                                  $"Total = ${Total:F2}";
            return Final_output;
                                  

        }
    }
}
