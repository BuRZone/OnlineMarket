using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.DAL.Entity
{

    public  class Order
    {
        public long Id { get; set; }

        public Product Product { get; set; }

        public DateTime DateCreated { get; set; }

        public string Address { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public Basket Basket { get; set; }
    }
}
