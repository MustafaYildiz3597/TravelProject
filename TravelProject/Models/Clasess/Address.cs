﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Clasess
{
    public class Address
    {
        public int AddressId { get; set; }
        public string  Title { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }

    }
}