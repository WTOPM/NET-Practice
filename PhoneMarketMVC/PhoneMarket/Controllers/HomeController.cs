using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneMarket.Models;

namespace PhoneMarket.Controllers
{
    public class HomeController : Controller
    {
        PhoneContext phoneContext = new PhoneContext();
        UserContext userContext = new UserContext();
        public ActionResult Index()
        {    //Извлекаем данные из таблицы Phones
            IEnumerable<Phone> phones = phoneContext.Phones;

            //Записываем phones в динамическое свойство ViewBag
            ViewBag.Phones = phones;

            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.DateTime = DateTime.Now;

            phoneContext.Purchases.Add(purchase);

            phoneContext.SaveChanges();

            return $"Уважаемый, {purchase.FIO}, с вами скоро свяжутся";
        }

        [HttpGet]
        public ActionResult SomeMethod()
        {
            ViewData["Date"] = DateTime.Now;
            return View("/Views/Home/MyView.cshtml");
        }
        [HttpGet]
        public ActionResult SomeView()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ListBooks()
        {
            return View(phoneContext.Phones);
        }

        [HttpGet]
        public ActionResult Register()
        {
            //Извлекаем данные из таблицы 
            IEnumerable<User> users = userContext.Users;

            //Записываем phones в динамическое свойство ViewBag
            ViewBag.Users = users;
            return View();
        }


    }
}