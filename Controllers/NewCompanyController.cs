using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using PickMe2.Models;

namespace PickMe2.Controllers
{
    public class NewCompanyController : Controller
    {
        // GET: NewCompany
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(Company nuc)
        {
            if (ModelState.IsValid)
            {
                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("https://localhost:44307/api/company");
                var insertdata = hc.PostAsJsonAsync<Company>("Company", nuc);
                insertdata.Wait();

                var savedata = insertdata.Result;
                if (savedata.IsSuccessStatusCode)
                {
                    ViewBag.message = "The User " + nuc.Company_name + " Is Saved ";
                }
            }
            return View();
        }
    }
}