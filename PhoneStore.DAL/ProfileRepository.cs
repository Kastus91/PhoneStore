using PhoneStore.DAL.Interfaces;
using PhoneStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.DAL
{
    public class ProfileRepository : IProfileRepository
    {

        private readonly PhoneDbContext _context;

        public ProfileRepository(PhoneDbContext context)
        {
            _context = context;
        }

        public bool Create(Profile entity)
        {
            _context.Add(entity);

            _context.SaveChanges();

            return true;
        }

        public bool Delete(Profile entity)
        {
            _context.Remove(entity);

            _context.SaveChanges();

            return true;
        }

        public Profile Get(int id)
        {
            return _context.Profiles.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Profile> GetAll()
        {
            return _context.Profiles.ToList();
        }

        public Profile Update(Profile entity)
        {
            _context.Update(entity);

            _context.SaveChanges();

            return entity;
        }
    }
}
