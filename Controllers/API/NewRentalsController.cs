using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.DTOs;

namespace Vidly.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDTO newRental)
        {
            throw new NotImplementedException();
        }

    }
}