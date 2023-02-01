using Microsoft.Ajax.Utilities;
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

        // This function simply takes an integer and returns its squared value

        // example
        //api/Square/5"  -> 25
        //api/Square/2"  -> 2

        [HttpGet]
        public int Square(int id)
        {
            // Here I have used the Math.Pow function for raisng the power of 2 to any input number
            int num = (int)Math.Pow(id, 2);
            return num;
        }
    }
}
