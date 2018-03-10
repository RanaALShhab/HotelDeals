using HotelDeals.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace HotelDeals.Controllers
{
    public class HotelController : Controller
    {
        // GET: Hotel
        static Rootobject ModelRootobject ; 
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetOfferInfo()
        {
            var OfferInfo = ModelRootobject.offerInfo;
            return PartialView("_HeaderOffersinfo", OfferInfo);

        }
        public ActionResult Login()
        {
            var webClient = new System.Net.WebClient();
            var json = webClient.DownloadString(@"https://offersvc.expedia.com/offers/v2/getOffers?scenario=deal-finder&page=foo&uid=foo&productType=Hotel");
            Rootobject Rootobject = JsonConvert.DeserializeObject<Rootobject>(json);
            ModelRootobject = Rootobject;
            var userInfo = ModelRootobject.userInfo;
            return PartialView("Login", userInfo);

        }

        public ActionResult GetHotelDestination()
        {
            var HotelDestination = ModelRootobject.offers.Hotel;
            return PartialView("_grdHotelDestination", HotelDestination);

        }
        public ActionResult GetHotelInformation ()
        {
            var HotelDestination = ModelRootobject.offers.Hotel;
            return PartialView("_grdHotelInfo", HotelDestination);

        }
        public ActionResult GetHotelPrice()
        {
            var HotelDestination = ModelRootobject.offers.Hotel;
            return PartialView("_grdHotelprice", HotelDestination);

        }
        [HttpPost]
        public ActionResult Search( string Paraname ,  int valuetap)
        {
            var Hotel= ModelRootobject.offers.Hotel;
            if (valuetap == 1)
            {
                var filter = from x in Hotel
                             where x.hotelInfo.hotelCity.Contains(Paraname) || x.hotelInfo.hotelCountryCode.Contains(Paraname)
                             || x.hotelInfo.hotelDestination.Contains(Paraname) || x.hotelInfo.hotelDestinationRegionID.Contains(Paraname)
                             || x.hotelInfo.hotelId.Contains(Paraname) || x.hotelInfo.hotelName.Contains(Paraname) || x.hotelInfo.hotelProvince.Contains(Paraname)
                             
                             select x
                               ;

                return PartialView("_grdHotelInfo", filter);

            }
           else if (valuetap == 2) {
                var filter = from x in Hotel
                             where x.destination.city.Contains(Paraname) || x.destination.country.Contains(Paraname)
                             || x.destination.shortName.Contains(Paraname) || x.destination.province.Contains(Paraname)
                             || x.destination.tla.Contains(Paraname) || x.destination.nonLocalizedCity.Contains(Paraname)
                             || x.destination.regionID.Contains(Paraname)
                             select x
                             ;

                return PartialView("_grdHotelDestination", filter);
            }
            else
            {
                var filter = from x in Hotel
                             where x.hotelPricingInfo.currency.Contains(Paraname) || x.offerDateRange.lengthOfStay.ToString().Contains(Paraname)
                             
                              
                             select x
                            ;

                return PartialView("_grdHotelprice", filter);

            }
        }

    }
}