using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Week2Project1.Controllers
{
    public class ExampleController : ApiController
    {
        // We want to have the webserver respond to a request
        // localhost:1234/api/example -> "Hello"

        [HttpGet]
        [Route("api/AddTen/addten/{id}")]
        public string Get()
        {
            return "Hello";
        }

    }
}
