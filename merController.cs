using ChoiceProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChoiceProject.Controllers
{
    public class merController : ApiController
    {
        public MerTable get(string pname)
        {
            return new MerTable(pname);
        }
    }
}
