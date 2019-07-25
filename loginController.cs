using ChoiceProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MongoDB.Bson;
using static ChoiceProject.Models.MerchantDOA;

namespace ChoiceProject.Controllers
{
    public class loginController : ApiController
    {
        [HttpGet]
        public LoginResponse post(Int64 phone, string password)
        {
            MerchantDOA d = new MerchantDOA();
            //List<string> s = new List<string> { };
            //s = d.authenticate(phone, password);
            LoginResponse lr = d.authenticate(phone, password);

            return lr;
        }


    }
}
