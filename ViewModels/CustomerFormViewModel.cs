using System.Collections.Generic;
using VideoRentalApps.Models;

namespace VideoRentalApps.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        public string Title
        {
            get
            {
                if (Customer != null && Customer.Id != 0)
                    return "Edit Customer";

                else
                    return "New Customer";

            }
        }
    }

   
}