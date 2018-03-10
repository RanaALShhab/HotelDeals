using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelDeals.Models
{
    public class Rootobject
    {
        public Offerinfo offerInfo { get; set; }
        public Userinfo userInfo { get; set; }
        public Offers offers { get; set; }
    }

    public class Offerinfo
    {
        public string siteID { get; set; }
        public string language { get; set; }
        public string currency { get; set; }
        public string userSelectedCurrency { get; set; }
    }

    public class Userinfo
    {
        public Persona persona { get; set; }
        public string userId { get; set; }
    }

    public class Persona
    {
        public string personaType { get; set; }
    }

    public class Offers
    {
        public Hotel[] Hotel { get; set; }
    }

    public class Hotel
    {
        public Offerdaterange offerDateRange { get; set; }
        public Destination destination { get; set; }
        public Hotelinfo hotelInfo { get; set; }
        public Hotelpricinginfo hotelPricingInfo { get; set; }
        public Hotelurls hotelUrls { get; set; }
    }

    public class Offerdaterange
    {
        public int[] travelStartDate { get; set; }
        public int[] travelEndDate { get; set; }
        public int lengthOfStay { get; set; }
    }

    public class Destination
    {
        public string regionID { get; set; }
        public string associatedMultiCityRegionId { get; set; }
        public string longName { get; set; }
        public string shortName { get; set; }
        public string country { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string tla { get; set; }
        public string nonLocalizedCity { get; set; }
    }

    public class Hotelinfo
    {
        public string hotelId { get; set; }
        public string hotelName { get; set; }
        public string localizedHotelName { get; set; }
        public string hotelDestination { get; set; }
        public string hotelDestinationRegionID { get; set; }
        public string hotelLongDestination { get; set; }
        public string hotelStreetAddress { get; set; }
        public string hotelCity { get; set; }
        public string hotelProvince { get; set; }
        public string hotelCountryCode { get; set; }
        public float hotelLatitude { get; set; }
        public float hotelLongitude { get; set; }
        public string hotelStarRating { get; set; }
        public float hotelGuestReviewRating { get; set; }
        public int hotelReviewTotal { get; set; }
        public string hotelImageUrl { get; set; }
        public bool vipAccess { get; set; }
        public bool isOfficialRating { get; set; }
    }

    public class Hotelpricinginfo
    {
        public float averagePriceValue { get; set; }
        public float totalPriceValue { get; set; }
        public float crossOutPriceValue { get; set; }
        public float originalPricePerNight { get; set; }
        public string currency { get; set; }
        public float percentSavings { get; set; }
        public bool drr { get; set; }
    }

    public class Hotelurls
    {
        public string hotelInfositeUrl { get; set; }
        public string hotelSearchResultUrl { get; set; }
    }


}