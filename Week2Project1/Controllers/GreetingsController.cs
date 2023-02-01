using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Week2Project1.Controllers
{
    public class GreetingsController : ApiController
    {
        [HttpPost]
        [Route("api/Greetings/Greeting/{str}")]
        public string Greeting(string str)
        {
            return str;
        }
    }
}
