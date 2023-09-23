using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01612422Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET api/HostingCost/{id} --> 3 strings which describe the total hosting cost
        /// <summary>
        /// This method calculates the hosting and maintance cost and return the response in 3 strings.
        /// </summary>
        /// <param name="id">number of days for hosting</param>
        /// <returns>3 strings which describe the total hosting cost</returns>
        public string[] Get(int id)
        {
            int numOfDayElapsed = id + 1; // Including day 0
            double costPerFortnight = 5.50;
            int numOfFortnight = (int)Math.Ceiling( (double)(numOfDayElapsed / 14.0));
            double costBeforeTax = numOfFortnight * costPerFortnight; // type cast to double to keep the percision
            double hst = costBeforeTax * 13.0 / 100.0;
            // double hstTwoDecimalPlace = Math.Floor(hst * 100) / 100;
            double total = costBeforeTax + hst; // Round down hst to nearest two decimal place
            string line1 = $"{numOfFortnight} fortnights at ${costPerFortnight:F2}/FN = ${costBeforeTax:F2} CAD";
            string line2 = $"HST 13% = ${hst:F2} CAD";
            string line3 = $"Total = ${total:F2} CAD";
            
            return new string[] { line1, line2, line3};
        }
    }
}
