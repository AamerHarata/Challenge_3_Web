using System;
using Challenge_3_Web.Enum;

namespace Challenge_3_Web.Models
{
    public class Window
    {
        public string Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double Mode { get; set; }
        public double Mean { get; set; }
        public double Std { get; set; }
        public Activity Activity { get; set; }
    }
}