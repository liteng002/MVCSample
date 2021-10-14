using BLL.Entities;
using BLL.Repositories;
using MVCSample.Filters;
using MVCSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class RegisterController : Controller
    {
        private UserRepository UserRepository;
        public RegisterController()
        {
            //UserRepository = new UserRepository();
        }

        // GET: Register
        [ModelErrorTransferFilter]
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        [ModelErrorTransferFilter]
        public ActionResult Index(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }


            if (UserRepository.GetByName(model.Name) != null)
            {
                ModelState.AddModelError("Name", "* 用户名不能重复");
                return RedirectToAction(nameof(Index));
            }
            User student = new User
            {
                Name = model.Name,
                Password = model.Password
            };
            student.Register();
            int id = UserRepository.Save(student);
            return View();

            ////首先有一个cookie，名字为user
            //HttpCookie cookie = new HttpCookie("user");

            ////在cookie中添加若干（2个）键值对
            //cookie.Values.Add("id", "98");
            //cookie.Values.Add("pwd", "1234");

            //cookie.Expires = DateTime.Now.AddDays(14);
            //Response.Cookies.Add(cookie);


            //if (!ModelState.IsValid)
            //{
            //    TempData["e"] = ModelState;
            //    return RedirectToAction(nameof(Index));

            //}
        }
    }
}