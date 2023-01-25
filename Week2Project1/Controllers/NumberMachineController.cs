using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Week2Project1.Controllers
{
    public class NumberMachineController : ApiController
    {
        public string get(int id)
        {
            var num1 = id + 2;
            var num2 = id * 2;
            var num3 = id / 2;
            var num4 = id - 2;

            return ("Addition of 2 to the input value = " + num1 + 
                "\n |||Multiplication by 2 of the input value = " + num2 + 
                "\n |||Division by 2 of the input value" + num3 + 
                "\n |||Subtraction by 2 of the input value " + num4 );
        }
    }
}
