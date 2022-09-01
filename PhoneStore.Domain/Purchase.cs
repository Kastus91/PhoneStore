using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Domain
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int PhoneId { get; set; }
        public DateTime DateTime { get; set; }
        public string Email { get; set; }
        public string FIO { get; set; }
        public string Address { get; set; }
    }
}
