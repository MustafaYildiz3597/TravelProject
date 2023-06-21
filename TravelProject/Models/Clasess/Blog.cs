using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelProject.Models.Clasess
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public DateTime date { get; set; }
        public string BlogImage { get; set; }
        public string Description { get; set; }

        public ICollection<Comments> comments { get; set;}
    }

}