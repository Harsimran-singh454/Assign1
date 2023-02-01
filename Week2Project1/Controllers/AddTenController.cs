using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace Week2Project1.Controllers
{
    public class AddTenController : ApiController
    {
        //This function will take an integer value and add 10 to it.

        //example

        //.../AddTen/5 -> 15
        //.../AddTen/10 -> 20
        //.../AddTen/2 -> 12

        [HttpGet]
        public int AddTen(int id)
        {
            int num = id+10;
            return num;
        }
    }
}
