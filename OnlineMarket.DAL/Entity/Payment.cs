using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.DAL.Entity
{
    public class Payment
    {
        public int Id { get; set; }
        public string PaymentDescription { get; set; }
        public decimal PaymentPrice { get; set; }
        public Seller Seller { get; set; }

        public bool IsApproved { get; set; }
    }
}
