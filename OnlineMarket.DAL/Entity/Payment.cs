using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineMarket.DAL.Entity
{
    public class Payment
    {
        public int Id { get; set; }
        public string PaymentDescription { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PaymentPrice { get; set; }
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
        public bool IsApproved { get; set; }
    }
}
