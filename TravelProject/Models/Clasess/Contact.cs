﻿using System.ComponentModel.DataAnnotations;

namespace TravelProject.Models.Clasess
{
    public class Contact
    {
        public int ContactId { get; set; }

        public string Name { get; set; }

        public string Mail { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
    }
}