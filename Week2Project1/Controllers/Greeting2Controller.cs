using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Week2Project1.Controllers
{
    public class Greeting2Controller : ApiController
    {
        public string get(int id)
        {
            var num = id;
            return ("Greetings to " + num + " People");
        }
    }
}

