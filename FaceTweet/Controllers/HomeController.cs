using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetOpenAuth.OAuth;

namespace FaceTweet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            try
            {
                return View("ValidationComplete");
            }
            catch (Exception)
            {
                return View("ValidationError");
            }
        }

    }
}
