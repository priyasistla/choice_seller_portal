using ChoiceProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChoiceProject.Controllers
{
    public class registerController : ApiController
    {
        [HttpGet]
        public List<string> Get(string name, Int64 phone, string email, string address, string password, string re_pass)
        {

            var s = new List<string>();
            s.Add("");
            MerchantDOA d = new MerchantDOA();
            d.create(name, phone, email, address, password, re_pass);
            return s;
        }
    }
}
