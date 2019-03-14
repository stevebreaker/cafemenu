using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cafemenurepo.Repositories;
using cafemenucore.Models;
using System.Threading.Tasks;
using System.Net.Http;

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

        public async Task<ActionResult> IndexRest()
        {

            HttpClient client = new HttpClient();

            var response = await client.GetAsync("http://localhost:50082/api/weeklymenu");

            response.EnsureSuccessStatusCode();

            ICollection<MenuDay> menuItems = await response.Content.ReadAsAsync<ICollection<MenuDay>>();


            return View("Index",menuItems);

        }

    }
}