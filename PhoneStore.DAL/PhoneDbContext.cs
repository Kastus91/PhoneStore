using Microsoft.EntityFrameworkCore;
using PhoneStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.DAL
{
    public class PhoneDbContext: DbContext
    {
        public PhoneDbContext(DbContextOptions<PhoneDbContext> options) : base(options)
        {
            Database.EnsureCreated();

            //EnsureDeleted
        }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<Purchase> Purchase { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Basket> Basket { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        
    }
}

