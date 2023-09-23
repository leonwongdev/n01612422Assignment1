using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01612422Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        // GET api/Square/{id} --> id * id
        /// <summary>
        /// This method returns the square of the id in path param.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>id * id</returns>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
