using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cafemenurepo.Repositories;
using cafemenucore.Models;
using System.Web.Helpers;

namespace cafemenu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult MenuItems()
        {
            MenuItemsRepository repo = new MenuItemsRepository();

            ICollection<MenuItem> menuItems = repo.Get();

            return Json(menuItems, JsonRequestBehavior.AllowGet);
        }

    }
}