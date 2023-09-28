using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;

namespace n01612422Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        // Post api/Greeting --> "Hello WOrld!"
        /// <summary>
        /// This method returns a greeting message "Hello World!" as a string.
        /// </summary>
        /// <returns>"Hello World!"</returns>
        public string Post()
        {
            return "Hello World!";
        }

        // GET api/Greeting/{id} --> "Greeting to {id} people!"
        /// <summary>
        /// Retrieves a greeting message based on the specified number of people and returns it as a string.
        /// </summary>
        /// <param name="id">The number of people to greet (an integer value).</param>
        /// <returns>"Greeting to {id} people!"</returns>
        public string Get(int id)
        {
            return $"Greeting to {id} people!";
        }
    }
}
