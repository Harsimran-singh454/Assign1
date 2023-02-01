using Microsoft.Ajax.Utilities;
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

        // This function takes a string and then return it to the user

        // example
        // /api/Greetings/Greeting/HelloWorld! -> HelloWorld!


        [HttpPost]
        [Route("api/Greetings/Greeting/{str}")]
        public string Greeting(string str)
        {
            return str;
        }
    }
}
