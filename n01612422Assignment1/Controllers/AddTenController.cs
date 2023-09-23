using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01612422Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        // GET api/AddTen/{id} --> id + 10
        /// <summary>
        /// This method takes in the path param "id" as an int and then return the result by adding 10 to it
        /// </summary>
        /// <param name="id"></param>
        /// <returns>id + 10</returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
