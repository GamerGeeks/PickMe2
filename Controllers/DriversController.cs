using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PickMe2.Models;

namespace PickMe2.Controllers
{
    public class DriversController : ApiController
    {
         public IHttpActionResult addnewdriver(DriversDB dr)
        {
            PickMe2Entities nd = new PickMe2Entities();
            nd.CompanyAdd(dr.Driver_id, dr.Driver_name, dr.Driver_address, dr.Driver_Pan, dr.Driver_license, dr.Company_contact);
            nd.SaveChanges();
            return Ok();
        }
    }
}
