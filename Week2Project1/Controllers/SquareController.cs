using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Week2Project1.Controllers
{
    public class SquareController : ApiController
    {
        public double get(int id)
        {
            var num = Math.Pow(id, 2);
            return num;
        }
    }
}
