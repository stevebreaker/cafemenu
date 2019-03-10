using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cafemenurepo.Repositories;
using cafemenucore.Models;
using System.Web.Helpers;
using System.Net.Http;
using System.Threading.Tasks;

namespace cafemenu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IMenuDayRepository repo = new MenuDayRepository();

            DateTime startWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            DateTime endWeek = startWeek.AddDays((int)DayOfWeek.Saturday);

            ICollection<MenuDay> menuItems = repo.Get(startWeek, endWeek);

            return View(menuItems);
        }

    }
}