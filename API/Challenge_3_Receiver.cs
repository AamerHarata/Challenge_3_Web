using Challenge_3_Web.Data;
using Challenge_3_Web.Enum;
using Challenge_3_Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Challenge_3_Web.API
{
    [ApiController]
    public class Challenge_3_Receiver : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public Challenge_3_Receiver(ApplicationDbContext context)
        {
            _context = context;
        }

        
        [Route("/api/Challenge_3_Receiver")]
        public IActionResult Receiver(int groupNumber, double xAco, double yAco, double zAco, double xGyro, double yGyro, double zGyro, Activity activity)
        {
            var rowData = new RowData()
            {
                GroupNumber = groupNumber, xAco = xAco, yAco = yAco, zAco = zAco, xGyro = xGyro, yGyro = yGyro, zGyro = zGyro,
                Activity = activity
            };
            _context.Add(rowData);
            _context.SaveChanges();
            
            var receivedData = "Gr. Nr: " + groupNumber + ", xAco: " + xAco + ", yAco: " + yAco + ", zAco: " + zAco +
                         ", xGyro: " + xGyro + ", yGyro: " + yGyro+", zGyro: "+zGyro+", Activity: "+ activity;
            
            return Ok(receivedData);
        }
    }
}