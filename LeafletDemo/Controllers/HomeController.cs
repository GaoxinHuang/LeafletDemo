using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeafletDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Title = "Home Page";
            List<string> westernLgaList = new List<string>()
            {
                "WARRNAMBOOL",
                "SWAN HILL",
                "SOUTHERN GRAMPIANS",
                "MILDURA",
                "YARRIAMBIACK",
                "HORSHAM",
                "GREATER BENDIGO",
                "PYRENEES",
                "MOORABOOL",
                "GREATER GEELONG",
                "COLAC OTWAY",
                "SURF COAST",
                "NORTHERN GRAMPIANS",
                "ARARAT",
                "GOLDEN PLAINS",
                "CORANGAMITE",
                "CAMPASPE",
                "BALLARAT",
                "BULOKE",
                "MOYNE",
                "HINDMARSH",
                "CENTRAL GOLDFIELDS",
                "MOUNT ALEXANDER",
                "HEPBURN",
                "GANNAWARRA",
                "WEST WIMMERA",
                "LODDON",
                "GLENELG"
            };
            List<string> districtsList = new List<string>()
            {
                "All",
                "Western - D2",
                "Western - D6",
                "Western - D5",
                "Western - D4",
                "Western - D3",
                "Western - D1"
            };
            ViewData["lgaName"] = westernLgaList;
            ViewData["districts"] = districtsList;
            return View();
        }
    }
}
