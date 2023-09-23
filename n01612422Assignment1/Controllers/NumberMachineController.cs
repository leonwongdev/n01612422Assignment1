using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01612422Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        // GET api/NumberMachine/{id} --> id * 100 / 10 + 10 - 10 
        /// <summary>
        /// Apply four math operation to the input id
        /// </summary>
        /// <param name="id">Input value to apply for math operations</param>
        /// <returns>id * 100 / 10 + 10 - 10</returns>
        public int Get(int id)
        {
            return id * 100 / 10 + 10 - 10;
        } 
    }
}
