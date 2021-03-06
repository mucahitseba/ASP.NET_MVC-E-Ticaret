﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_E_Ticaret.Models
{
    public class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string Image { get; set; }
        public bool isApproved { get; set; }
        public bool isFeatured { get; set; }
        public bool isHome { get; set; }


    }
}