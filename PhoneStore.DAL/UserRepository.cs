using PhoneStore.DAL.Interfaces;
using PhoneStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.DAL
{
    public class UserRepository : IUserRepository
    {

        private readonly PhoneDbContext _context;

        public UserRepository(PhoneDbContext context)
        {
            _context = context;
        }

        public bool Create(User entity)
        {
            _context.Add(entity);

            _context.SaveChanges();

            return true;
        }

        public bool Delete(User entity)
        {
            _context.Remove(entity);

            _context.SaveChanges();

            return true;
        }

        public User Get(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User Update(User entity)
        {
            _context.Update(entity);

            _context.SaveChanges();

            return entity;
        }
    }
}
