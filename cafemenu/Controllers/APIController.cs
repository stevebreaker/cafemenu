using cafemenucore.Models;
using cafemenurepo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cafemenu.Controllers
{
    public class APIController : Controller
    {
        public JsonResult MenuItems()
        {
            IMenuItemsRepository repo = new MenuItemsRepository();

            ICollection<MenuItem> menuItems = repo.Get();

            return Json(menuItems, JsonRequestBehavior.AllowGet);
        }

        public JsonResult MenuSchedule()
        {
            IMenuDayRepository repo = new MenuDayRepository();

            DateTime startWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            DateTime endWeek = startWeek.AddDays((int)DayOfWeek.Saturday);

            ICollection<MenuDay> menuItems = repo.Get(startWeek, endWeek);

            return Json(menuItems, JsonRequestBehavior.AllowGet);
        }
    }
}