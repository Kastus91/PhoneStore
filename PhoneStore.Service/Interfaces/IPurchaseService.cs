using PhoneStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Service.Interfaces
{
    public interface IPurchaseService
    {
        public Purchase GetPurchase(int id);

        public bool CreatePurchase(Purchase entity);


    }
}
