﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.DAL.Entity
{
    public class Basket
    {
        [Key]
        public int Id { get; set; }
        public IEnumerable<Product> Product { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
