﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.DAL.Entity
{
    public class Seller
    {
        public int Id { get; set; }
        public string SellerName { get; set; }
        public string SellerDescription { get; set; }
        public User User { get; set; } 
        public IEnumerable<Category> Category { get; set; }
        public IEnumerable<Product> Product { get; set; }
        public IFormFile? SellerformFile { get; set; }
        public byte[]? SellerLogo { get; set; }
    }
}