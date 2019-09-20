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
            if((doubleIsZero(xGyro) && doubleIsZero(yGyro) && doubleIsZero(zGyro)) || (doubleIsZero(xLinAco) && doubleIsZero(yLinAco) && doubleIsZero(zLinAco)))
                return Ok();
            var rowData = new RowData()
            {
                GroupNumber = groupNumber, xAco = xAco, yAco = yAco, zAco = zAco, xGyro = xGyro, yGyro = yGyro, zGyro = zGyro,
                xLinAco = xLinAco, yLinAco = yLinAco, zLinAco = zLinAco, xMag = xMag, yMag = yMag, zMag = zMag,
                Activity = activity, Pred = pred, TimeStamp = DateTime.Now,
                AcoSMV = SMV(xAco, yAco, zAco), LinAcoSMV = SMV(xLinAco, yLinAco, zLinAco), GyroSMV = SMV(xGyro, yGyro, zGyro)
            };
            _context.Add(rowData);
            _context.SaveChanges();
            
            var receivedData = "groupNumber" + groupNumber + ", xAco: " + xAco + ", yAco: " + yAco + ", zAco: " + zAco +", xLinAco: " + xLinAco +", yLinAco: "+yLinAco +", zLinAco: " + zLinAco
                               +", xMag: " + xMag + ", yMag: "+ yMag+", zMag: "+ zMag
                         +", xGyro: " + xGyro + ", yGyro: " + yGyro+", zGyro: "+zGyro+", Activity: "+ activity+", Pred: "+ pred;
            
            return Ok(receivedData);
        }


        [Route("api/Challenge_3_WindowReceiver")]
        public IActionResult WindowReceiver(double MaxAcoSMV, double MinAcoSMV, double MeanAcoSMV, double ModeAcoSMV, double StdAcoSMV,
            double MaxLinAcoSMV, double MinLinAcoSMV, double MeanLinAcoSMV, double ModeLinAcoSMV, double StdLinAcoSMV,
            double MaxGyroSMV, double MinGyroSMV, double MeanGyroSMV, double ModeGyroSMV, double StdGyroSMV,
            Activity activity)
        {
            if (doubleIsZero(MeanAcoSMV) || doubleIsZero(MeanGyroSMV) || doubleIsZero(MeanLinAcoSMV))
                return Ok();
            
            var window = new Window()
            {
                MinAcoSMV = MinAcoSMV, MaxAcoSMV = MaxAcoSMV, MeanAcoSMV = MeanAcoSMV, ModeAcoSMV = ModeAcoSMV, StdAcoSMV = StdAcoSMV,
                MinLinAcoSMV = MinLinAcoSMV, MaxLinAcoSMV = MaxLinAcoSMV, MeanLinAcoSMV = MeanLinAcoSMV, ModeLinAcoSMV = ModeLinAcoSMV, StdLinAcoSMV = StdLinAcoSMV, 
                MinGyroSMV = MinGyroSMV, MaxGyroSMV = MaxGyroSMV, MeanGyroSMV = MeanGyroSMV, ModeGyroSMV = ModeGyroSMV, StdGyroSMV = StdGyroSMV,
                Activity = activity, TimeStamp = DateTime.Now
            };

            _context.Add(window);
            _context.SaveChanges();

            var receivedData = "New Window Saved .. OK()";
            return Ok(receivedData);
            
            
        }
        
        
        
        

        private double SMV(double x, double y, double z)
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        private bool doubleIsZero(double num)
        {
            return Math.Abs(num) < 0.000001;
        }
    }
}