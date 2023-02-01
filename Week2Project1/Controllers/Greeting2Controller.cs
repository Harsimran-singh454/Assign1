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
        // This function takes an integer and then uses it and returns it with a string

        // example

        // /api/Greeting2/21  -> Greetings to 21 people
        // /api/Greeting2/3   -> Greetings to 3 people
        // /api/Greeting2/25  -> Greetings to 25 people
        [HttpGet]
        public string Greetings(int id)
        {
            int num = id;
            return ("Greetings to " + num + " People");
        }
    }
}