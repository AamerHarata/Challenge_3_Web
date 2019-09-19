using System;
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
        public IActionResult Receiver(int groupNumber, double xAco, double yAco, double zAco, double xGyro, double yGyro, double zGyro,
            double xLinAco, double yLinAco, double zLinAco, double xMag, double yMag, double zMag,
            Activity activity, int pred)
        {
            var rowData = new RowData()
            {
                GroupNumber = groupNumber, xAco = xAco, yAco = yAco, zAco = zAco, xGyro = xGyro, yGyro = yGyro, zGyro = zGyro,
                xLinAco = xLinAco, yLinAco = yLinAco, zLinAco = zLinAco, xMag = xMag, yMag = yMag, zMag = zMag,
                Activity = activity, Pred = pred,
                AcoSMV = SMV(xAco, yAco, zAco), LinAcoSMV = SMV(xLinAco, yLinAco, zLinAco), GyroSMV = SMV(xGyro, yGyro, zGyro)
            };
            _context.Add(rowData);
            _context.SaveChanges();
            
            var receivedData = "Gr. Nr: " + groupNumber + ", xAco: " + xAco + ", yAco: " + yAco + ", zAco: " + zAco +", xLinAco: " + xLinAco +", yLinAco: "+yLinAco +", zLinAco: " + zLinAco
                               +", xMag: " + xMag + ", yMag: "+ yMag+", zMag: "+ zMag
                         +", xGyro: " + xGyro + ", yGyro: " + yGyro+", zGyro: "+zGyro+", Activity: "+ activity+", Pred: "+ pred;
            
            return Ok(receivedData);
        }

        private double SMV(double x, double y, double z)
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }
}