using ChoiceProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChoiceProject.Controllers
{
    public class TableController : ApiController
    {
        public TableData get(string uat)
        {
            return new TableData(uat);
        }

        public string get(int d)
        {
            return "value";
        }
    }
}
