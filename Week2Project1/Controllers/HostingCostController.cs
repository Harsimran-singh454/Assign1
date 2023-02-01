using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Week2Project1.Controllers
{
    public class HostingCostController : ApiController
    {

        // This functions takes number of days(integer) as input, then calculate the cost, add tax to it, and returns total cost to the user
        
        // example
        
        ///api/HostingCost/21 ->        1.  2 Fortnights at $11      
                                     ///2.   HST 13% = $1.43         
                                     ///3.   Total = $12.43
        
        [HttpGet]
        public string HostingCost(int id)
        {
            double FN = (float)(id / 14) + 1;
            //This is the logic if user enters less than 1 day, so it will still be 1 FN
            if (FN < 1)
            {
                FN = 1;
            }

            // The else statement is used for using the regular value for FN
            else
            {
                FN = FN + 0;
            }

            // This logic is for calculating and adding tax
            double WoHST = (double)FN * 5.50;
            double HST = (double)(.13) * WoHST;
            double WHST = (float)WoHST + HST;

            return ("1.  " + FN + " Fortnights at $" + WoHST + " |||     2.   HST 13% = $" + HST + "    |||     3.   Total = $" + WHST);
        }
    }
}
