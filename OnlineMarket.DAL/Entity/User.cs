using OnlineMarket.DAL.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineMarket.DAL.Entity
{

    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; } = Role.User;
        public decimal Balance { get; set; }
        public Basket Basket { get; set; }
        public decimal Purchase { get; set; }

    }
}
