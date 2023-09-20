using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01612422Assignment1.Controllers
{
    public class TimesFiftyController : ApiController
    {

        //GET api/TimesFifty --> "Hello"
        public string Get()
        {
            return "Hello";
        }

        public string Post()
        {
            return "Post method here";
        }

    }
}
