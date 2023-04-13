using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Statistical_Weather_API.Domain
{
    public partial class Forecastdata
    {
        public int Id { get; set; }
        public int? CityId { get; set; }
        public int? Day { get; set; }
        public int? Month { get; set; }
        public double? TempMedian { get; set; }
        public double? CloudMedian { get; set; }
        public DateTime? Lastupdated { get; set; }
    }
}
