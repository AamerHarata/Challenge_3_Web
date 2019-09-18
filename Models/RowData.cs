using Challenge_3_Web.Enum;

namespace Challenge_3_Web.Models
{
    public class RowData
    {
        public string Id { get; set; }
        public double xGeo { get; set; }
        public double yGeo { get; set; }
        public Activity Activity { get; set; }
    }
}