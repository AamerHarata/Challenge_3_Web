using Microsoft.AspNetCore.Mvc;

namespace Challenge_3_Web.API
{
    [ApiController]
    public class Challenge_3_Receiver : ControllerBase
    {
        public Challenge_3_Receiver()
        {
            
        }

        public IActionResult Receiver()
        {
            return Ok();
        }
    }
}