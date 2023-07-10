using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.DAL.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public IEnumerable<Product>? Product { get; set; }
        public IEnumerable<Seller>? Seller { get; set; }

    }
}
