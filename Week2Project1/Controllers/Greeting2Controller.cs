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
        [HttpGet]
        [Route("api/Greeting2/Greetings/{id}")]
        public string Greetings(int id)
        {
            int num = id;
            return ("Greetings to " + num + " People");
        }
    }
}