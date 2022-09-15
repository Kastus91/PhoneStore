using Microsoft.EntityFrameworkCore;
using PhoneStore.DAL.Interfaces;
using PhoneStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.DAL
{
    public class PhoneRepository : IPhoneRepository
    {
        private readonly PhoneDbContext _context;

        public PhoneRepository(PhoneDbContext context)
        {
            _context = context;
        }

        public bool Create(Phone entity)
        {
            _context.Add(entity);

            _context.SaveChanges();

            return true;
        }

        public bool Delete(Phone entity)
        {
            _context.Remove(entity);

            _context.SaveChanges();

            return true;
        }

        public Phone Get(int id)
        {
            return _context.Phones.FirstOrDefault(x=> x.PhoneId == id);
        }

        public IEnumerable <Phone> GetAll()
        {
            return _context.Phones.ToList();
        }

        public Phone GetByName(string name)
        {
            return _context.Phones.FirstOrDefault(x => x.Name == name);
        }

        public Phone Update(Phone entity)
        {
            _context.Update(entity);
            
            _context.SaveChanges();

            return entity;
        }
    }
}
