using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class ArticleController : Controller
    {
        public ActionResult Index(int id)
        {
            return View();
        }

        public ActionResult fg()
        {

            return View();
        }


    }
}