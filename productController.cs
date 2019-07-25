using ChoiceProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChoiceProject.Controllers
{
    public class productController : ApiController
    {
        [HttpGet]
        public List<string> get(string pname,Int32 productprice,string category, string subcategory, string physicalprop,string phonenumber)
        {

            var s = new List<string>();
            s.Add("insert avutunna chudu");
            ProductDOA d = new ProductDOA();
            d.pcreate(pname, productprice, category, subcategory, physicalprop,phonenumber);
            return s;
        }
    }
}
