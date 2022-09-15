using PhoneStore.Domain;
using PhoneStore.Domain.Responce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Service.Interfaces
{
    public interface IPhoneService
    {
        // public IEnumerable<Phone> GetAllPhones();

        public IEnumerable<Phone> GetPhones();


    }
}
