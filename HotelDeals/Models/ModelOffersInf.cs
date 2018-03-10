using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelDeals.Models
{
    public class ModelOffersInf

    {
        public int siteID { get; set; }
        public string language { get; set; }
        public string currency { get; set; }
        public string userSelectedCurrency { get; set; }
    }

    public class userInfo

    {
        public int userId { get; set; }
        public string persona { get; set; }
        
    }
}