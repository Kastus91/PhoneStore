using PhoneStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.DAL
{
    public static class SampleData
    {
        public static void Initialize(PhoneDbContext context)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Name = "iPhone 13Pro",
                        Produce = "Apple",
                        Price = 3500
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxy S10",
                        Produce = "Samsung",
                        Price = 1900
                    },
                    new Phone
                    {
                        Name = "Xiaomi Redmi 10S",
                        Produce = "Xiaomi",
                        Price = 800
                    },
                    new Phone
                    {
                        Name = "Huawei P20",
                        Produce = "Huawei",
                        Price = 600
                    },
                    new Phone
                    {
                        Name = "HONOR X8",
                        Produce = "HONOR",
                        Price = 900
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
