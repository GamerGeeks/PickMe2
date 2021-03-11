using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PickMe2.Models;
using static PickMe2.Models.Locations;

namespace PickMe2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            LocationLists model = new LocationLists();
            var locations = new List<Locations>()
            {
                new Locations(1, "Bhubaneswar","Bhubaneswar, Odisha", 20.296059, 85.824539),
                new Locations(2, "Hyderabad","Hyderabad, Telengana", 17.387140, 78.491684),
                new Locations(3, "Bengaluru","Bengaluru, Karnataka", 12.972442, 77.580643)
            };
            model.LocationList = locations;

            return View(model);
        }
    }
}
