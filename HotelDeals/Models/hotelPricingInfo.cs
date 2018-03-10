using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelDeals.Models
{
    public class hotelPricingInfo
    {
        public int averagePriceValue { get; set; }
        public int crossOutPriceValue { get; set; }
        public string currency { get; set; }
        public bool drr { get; set; }
        public int originalPricePerNight { get; set; }
        public int percentSavings { get; set; }
        public int totalPriceValue { get; set; }
 
    }
}