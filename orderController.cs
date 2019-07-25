using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ChoiceProject.Models;

namespace ChoiceProject.Controllers
{
    public class orderController : ApiController
    {
        public OrderTable get(string merchantid)
        {
            return new OrderTable(merchantid);
        }
    }
}
