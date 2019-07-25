using ChoiceProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChoiceProject.Controllers
{
    public class customerController : ApiController
    {
        [HttpGet]
        public List<string> get(string name, Int64 phone, string email,string pname,string address)
        {

            var s = new List<string>();
            s.Add("Order placed Successfully");
            MerchantDOA d = new MerchantDOA();
            d.createCustomer(name, phone, email,pname, address);
            return s;
        }
    }
}
