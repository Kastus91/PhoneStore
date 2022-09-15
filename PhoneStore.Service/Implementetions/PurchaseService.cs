using PhoneStore.DAL.Interfaces;
using PhoneStore.Domain;
using PhoneStore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Service.Implementetions
{
    public class PurchaseService : IPurchaseService
    {

        private readonly IPurchaseRepository _purchaseRepository;

        public PurchaseService(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }

        public bool CreatePurchase(Purchase entity)
        {
            var purchase = new Purchase()
            {
                Email = entity.Email,

                FIO = entity.FIO,

                Address = entity.Address,

                DateTime = entity.DateTime,

                PhoneId = entity.PhoneId,

                PurchaseId = entity.PurchaseId,
            };

            _purchaseRepository.Create(purchase);

            return true;

            

            
        }

        public Purchase GetPurchase(int id)
        {
            var purchase = _purchaseRepository.Get(id);

            return purchase;
        }
    }
}
