using PhoneStore.DAL.Interfaces;
using PhoneStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.DAL
{
    public class BasketRepository : IBasketRepository
    {

        private readonly PhoneDbContext _context;

        public BasketRepository(PhoneDbContext context)
        {
            _context = context;
        }

        public bool Create(Basket entity)
        {
            _context.Add(entity);

            _context.SaveChanges();

            return true;
        }

        public bool Delete(Basket entity)
        {
            _context.Remove(entity);

            _context.SaveChanges();

            return true;
        }

        public Basket Get(int id)
        {
            return _context.Basket.FirstOrDefault(x => x.PhoneId == id);
        }

        public IEnumerable<Basket> GetAll()
        {
            return _context.Basket.ToList();
        }

        public Basket Update(Basket entity)
        {
            _context.Update(entity);

            _context.SaveChanges();

            return entity;
        }
    }
}
