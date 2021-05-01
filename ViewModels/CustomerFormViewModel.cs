using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoRentalApps.Models;

namespace VideoRentalApps.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MemberShipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

    }
}