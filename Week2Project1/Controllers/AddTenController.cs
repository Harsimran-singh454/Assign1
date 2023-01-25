using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Week2Project1.Controllers
{
    public class AddTenController : ApiController
    {
        
        public int get(int id)
        {
            var num = id+10;
            return num;
        }
       
    }
}
