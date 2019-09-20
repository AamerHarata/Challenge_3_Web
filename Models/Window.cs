using System;
using Challenge_3_Web.Enum;

namespace Challenge_3_Web.Models
{
    public class Window
    {
        public string Id { get; set; }
        public DateTime TimeStamp { get; set; }
//        public double Min { get; set; }
//        public double Max { get; set; }
//        public double Mode { get; set; }
//        public double Mean { get; set; }
//        public double Std { get; set; }



        // ToDo :: ACO
        //X
//        public double MaxXAco { get; set; }
//        public double MinXAco { get; set; }
//        public double MeanXAco { get; set; }
//        public double ModeXAco { get; set; }
//        public double StdXAco { get; set; }
//        
//        //Y
//        public double MaxYAco { get; set; }
//        public double MinYAco { get; set; }
//        public double MeanYAco { get; set; }
//        public double ModeYAco { get; set; }
//        public double StdYAco { get; set; }
//        
//        //Z
//        public double MaxZAco { get; set; }
//        public double MinZAco { get; set; }
//        public double MeanZAco { get; set; }
//        public double ModeZAco { get; set; }
//        public double StdZAco { get; set; }
//        
//        // ToDo :: LINACO
//        //X
//        public double MaxXLinAco { get; set; }
//        public double MinXLinAco { get; set; }
//        public double MeanXLinAco { get; set; }
//        public double ModeXLinAco { get; set; }
//        public double StdXLinAco { get; set; }
//        
//        //Y
//        public double MaxYLinAco { get; set; }
//        public double MinYLinAco { get; set; }
//        public double MeanYLinAco { get; set; }
//        public double ModeYLinAco { get; set; }
//        public double StdYLinAco { get; set; }
//        
//        //Z
//        public double MaxZLinAco { get; set; }
//        public double MinZLinAco { get; set; }
//        public double MeanZLinAco { get; set; }
//        public double ModeZLinAco { get; set; }
//        public double StdZLinAco { get; set; }
//        
//        
//        
//        // ToDo :: GYRO
//        //X
//        public double MaxXGyro { get; set; }
//        public double MinXGyro { get; set; }
//        public double MeanXGyro { get; set; }
//        public double ModeXGyro { get; set; }
//        public double StdXGyro { get; set; }
//        
//        //Y
//        public double MaxYGyro { get; set; }
//        public double MinYGyro { get; set; }
//        public double MeanYGyro { get; set; }
//        public double ModeYGyro { get; set; }
//        public double StdYGyro { get; set; }
//        
//        //Z
//        public double MaxZGyro { get; set; }
//        public double MinZGyro { get; set; }
//        public double MeanZGyro { get; set; }
//        public double ModeZGyro { get; set; }
//        public double StdZGyro { get; set; }
        
        
        //ToDo :: SMV
        //ACO
        public double MaxAcoSMV { get; set; }
        public double MinAcoSMV { get; set; }
        public double MeanAcoSMV { get; set; }
        public double ModeAcoSMV { get; set; }
        public double StdAcoSMV { get; set; }
        
        //LINACO
        public double MaxLinAcoSMV { get; set; }
        public double MinLinAcoSMV { get; set; }
        public double MeanLinAcoSMV { get; set; }
        public double ModeLinAcoSMV { get; set; }
        public double StdLinAcoSMV { get; set; }
        
        //GYRO
        public double MaxGyroSMV { get; set; }
        public double MinGyroSMV { get; set; }
        public double MeanGyroSMV { get; set; }
        public double ModeGyroSMV { get; set; }
        public double StdGyroSMV { get; set; }
        
        
        
        
        
        
        
        public Activity Activity { get; set; }
    }
}