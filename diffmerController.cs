using ChoiceProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChoiceProject.Controllers
{
    public class diffmerController : ApiController
    {
        [HttpGet]
        public List<string> get()
        {
            ProductDOA d = new ProductDOA();
            List<string> s = new List<string> { };
            List<string> s1 = new List<string> { };
            s1 = d.FindAll();
            s = d.generate("Laptops");
            return s1;
        }
    }
}
