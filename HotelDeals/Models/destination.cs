using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelDeals.Models
{
    public class destination
    {
        public int associatedMultiCityRegionId { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string longName { get; set; }
        public string nonLocalizedCity { get; set; }
        public string province { get; set; }
        public int regionID { get; set; }
        public string shortName { get; set; }
        public string tla { get; set; }
    }
}