using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Domain
{
    public class Basket
    {
        public int BasketId { get; set; }
        public int UserId { get; set; }
        //public User User { get; set; }
        public List<Order> Orders { get; set; }


    }
}
