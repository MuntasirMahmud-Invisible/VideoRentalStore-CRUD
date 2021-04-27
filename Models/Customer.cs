﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoRentalApps.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public DateTime? DateofBirth { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MemberShipType memberShipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}