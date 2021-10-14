using BLL.Entities;
using BLL.Repositories;
using MVCSample.Models.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class HomeController : Controller
    {

        private ArticleRepository articleRepository;
        private UserRepository userRepository;
        public HomeController()
        {
            SqlDbContext context = new SqlDbContext();
            articleRepository = new ArticleRepository(context);
            userRepository = new UserRepository(context);

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }
        [HttpPost]
        public ActionResult New(NewModel model)
        {
            int currentUserId = 1;

            Article article = new Article
            {
                Title = model.Title,
                Body = model.Body,
              //  AuthorId = currentUserId

            };

           // User author = userRepository.Fing(currentUserId);
            User author = userRepository.LoadProxy(currentUserId);
            article.Author = author;
            articleRepository.Save(article);

            return View();
            //var state1 = userRepository.context.Entry(author).State;


            // var state2 = articleRepository.context.Entry(author).State;
            //articleRepository.context.Entry(author).State =
            //    System.Data.Entity.EntityState.Unchanged;
            // articleRepository.context.Set<User>().Attach(author);


        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact(int? id)
        //{
        //    ViewBag.Message = "Your contact page.";
        //    ViewData["id"] = id;
        //    return View();
        //}
    }
}