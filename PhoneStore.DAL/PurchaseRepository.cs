using PhoneStore.DAL.Interfaces;
using PhoneStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.DAL
{
    public class PurchaseRepository : Interfaces.IPurchaseRepository
    {
        private readonly PhoneDbContext _context;

        public PurchaseRepository(PhoneDbContext context)
        {
            _context = context;
        }

        public bool Create(Purchase entity)
        {
            _context.Add(entity);

            _context.SaveChanges();

            return true;
        }

        public bool Delete(Purchase entity)
        {
            _context.Remove(entity);

            _context.SaveChanges();

            return true;
        }

        public Purchase Get(int id)
        {
            return _context.Purchase.FirstOrDefault(x => x.PurchaseId == id);
        }

        public IEnumerable<Purchase> GetAll()
        {
            return _context.Purchase.ToList();
        }

        public Purchase Update(Purchase entity)
        {
            _context.Update(entity);

            _context.SaveChanges();

            return entity;
        }
    }
}
