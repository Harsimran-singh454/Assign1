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
        [HttpGet]
        public string NumberMachine(int id)
        {
            int num1 = id + 2;
            int num2 = id * 2;
            int num3 = id / 2;
            int num4 = id - 2;

            return ("Addition of 2 to the input value = " + num1 + 
                "   |||Multiplication by 2 of the input value = " + num2 + 
                "   |||Division by 2 of the input value" + num3 + 
                "   |||Subtraction by 2 of the input value " + num4 );
        }
    }
}
