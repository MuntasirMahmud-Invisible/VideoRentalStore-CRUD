    using System;
using System.ComponentModel.DataAnnotations;
using VideoRentalApps.Models;

namespace VideoRentalApps.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

     //   [Min18YearsIfaMember]
        public DateTime? DateofBirth { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}