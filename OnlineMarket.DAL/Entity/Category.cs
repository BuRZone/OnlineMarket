﻿namespace OnlineMarket.DAL.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int SubCategoryId { get; set; }
        public IEnumerable<SubCategory> SubCategory { get; set; }
        public IEnumerable<Product>? Product { get; set; }
        public IEnumerable<Seller>? Seller { get; set; }

    }
}
