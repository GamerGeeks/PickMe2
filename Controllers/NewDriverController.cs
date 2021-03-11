using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using PickMe2.Models;

namespace PickMe2.Controllers
{
    public class NewDriverController : Controller
    {
        // GET: NewDriver
        [HttpPost]
        public ActionResult Index(Drivers drs)
        {
            if (ModelState.IsValid) { 
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44307/api/Drivers");
            var insertDriver = hc.PostAsJsonAsync<Drivers>("Drivers", drs);
            insertDriver.Wait();
            var saveDriver = insertDriver.Result;
            if (saveDriver.IsSuccessStatusCode)
            {
                ViewBag.message = "" + drs.Driver_name + " is added";
            }
            }
            return View();
        }
    }
}