using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoRentalApps.Models;

namespace VideoRentalApps.ViewModels
{
    public class MovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customer { get; set; }

    }
}