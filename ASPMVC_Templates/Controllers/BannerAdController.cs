using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVC_Templates.Controllers
{
    public class BannerAdController : Controller
    {
        // GET: BannerAd
        [ChildActionOnly]
        public ActionResult GetAd()
        {
            var text = "Buy Coffee";
            if (DateTime.Now.Hour> 12 )
            {
                text = "Buy Alcohol";
            }
            return PartialView("_Ad", text);
        }
    }
}