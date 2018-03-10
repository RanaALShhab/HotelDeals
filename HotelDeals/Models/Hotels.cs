using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelDeals.Models
{
    public class Hotels

    {
        public List<destination> _destination { get; set; }
        public List<hotelInfo> _hotelInfo { get; set; }
        public List<hotelPricingInfo> _hotelPricingInfo { get; set; }
        public List<hotelUrls> _hotelUrls { get; set; }
        public List<offerDateRange> _offerDateRange { get; set; }
    }
}