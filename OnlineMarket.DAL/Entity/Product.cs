using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.DAL.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Category Category { get; set; }
        public Seller Seller { get; set; }
        public IFormFile? ProductformFile { get; set; }
        public byte[]? ProductPhoto { get; set; }
    }
}
