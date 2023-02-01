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

        // This function takes an integer as input and then perform 4 arithmatic operations on it

        //example

        ///api/NumberMachine/5" ->  "Addition of 2 to the input value = 7   
        ///                 |||      Multiplication by 2 of the input value = 10   
        ///                 |||      Division by 2 of the input value = 2   
        ///                 |||      Subtraction by 2 of the input value = 3
        

        [HttpGet]
        public string NumberMachine(int id)
        {
            int num1 = id + 2;
            int num2 = id * 2;
            int num3 = id / 2;
            int num4 = id - 2;

            return ("Addition of 2 to the input value = " + num1 + 
                "   |||Multiplication by 2 of the input value = " + num2 + 
                "   |||Division by 2 of the input value = " + num3 + 
                "   |||Subtraction by 2 of the input value = " + num4 );
        }
    }
}
