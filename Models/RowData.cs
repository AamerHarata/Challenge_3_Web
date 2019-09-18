using System;
using Challenge_3_Web.Enum;

namespace Challenge_3_Web.Models
{
    public class RowData
    {
        public string Id { get; set; }
        public int GroupNumber { get; set; }
        public DateTime TimeStamp { get; } = DateTime.Now;
        public double xAco { get; set; }
        public double yAco { get; set; }
        public double zAco { get; set; }
        public double xGyro { get; set; }
        public double yGyro { get; set; }
        public double zGyro { get; set; }
        public Activity Activity { get; set; }

    }
}