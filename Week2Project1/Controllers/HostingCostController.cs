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
        public string get(int id)
        {
            double FN = (float)(id / 14)+1;
            if (FN < 1)
            {
                FN = 1;
            }
            else
            {
                FN = FN+0;
            }
            
            double WoHST = (float)FN * 5.50;;
            double HST = (float)(13/100) * FN;
            double WHST = (float)WoHST + HST; 
            return ("1.  " + FN +" Fortnights at $" + WoHST +" ||| 2.   HST 13% = $" + HST + "||| 3.   Total = $"+WHST );
        }
    }
}
