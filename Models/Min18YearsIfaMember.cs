using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoRentalApps.Models
{
    public class Min18YearsIfaMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var Customer = (Customer)validationContext.ObjectInstance;

            if (Customer.MembershipTypeId == MemberShipType.Unknown ||
                Customer.MembershipTypeId == MemberShipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }

            if (Customer.DateofBirth == null)
            {
                return new ValidationResult("Birthday is Required");
            }

            var age = DateTime.Today.Year - Customer.DateofBirth.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success 
                : new ValidationResult("Customer should be at least 18 years to be a member");
        }
    }
}