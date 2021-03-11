using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PickMe2.Models;

namespace PickMe2.Controllers
{
    public class CompanyController : ApiController
    {
        public IHttpActionResult company(CompanyDB cdb)
        {
            PickMe2Entities pe = new PickMe2Entities();
            pe.CompanyInsert( cdb.Company_id, cdb.Company_name, cdb.Company_address, cdb.Company_vendor_name, cdb.Company_email, cdb.Company_contact);
            pe.SaveChanges();
            return Ok();
        }

        
        
        
    }
}
    