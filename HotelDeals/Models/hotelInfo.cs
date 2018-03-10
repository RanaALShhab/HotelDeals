using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelDeals.Models
{
    public class hotelInfo
    {
        public string hotelCity { get; set; }
        public string hotelCountryCode { get; set; }
        public string hotelDestination { get; set; }
        public int hotelDestinationRegionID { get; set; }
        public int hotelGuestReviewRating { get; set; }
        public int hotelId { get; set; }
        public string hotelImageUrl { get; set; }
        public int hotelLatitude { get; set; }
        public string hotelLongDestination { get; set; }
        public int hotelLongitude { get; set; }
        public string hotelName { get; set; }
        public string hotelProvince { get; set; }
        public int hotelReviewTotal { get; set; }
        public int hotelStarRating { get; set; }
        public int hotelStreetAddress { get; set; }
        public bool isOfficialRating { get; set; }
        public string localizedHotelName { get; set; }
        public bool vipAccess { get; set; }
    }
}