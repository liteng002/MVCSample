using BLL.Entities;
using MVCSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class SharedController : Controller
    {
        // GET: Shared
        //[ChildActionOnly]
        public ActionResult _User(int? level)
        {
            UserModel model = new UserModel
            {
                Id = 10,
                Name = "自由飞"
            };
            ViewBag.level = level;
            return PartialView(model);
        }
        [ChildActionOnly]
        public PartialViewResult _LogonStatus()
        {
            //Student
            return PartialView();
        }
    }
}