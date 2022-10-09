using PhoneStore.Domain;
using PhoneStore.Domain.Responce;
using PhoneStore.Domain.ViewModels;
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

        public Phone GetPhone(int id);

        public Phone GetPhoneByName(string name);

        public bool CreatePhone(PhoneViewModel phoneViewModel);

        public bool DeletePhone(int id);

        public Phone Edit(int id, PhoneViewModel phoneViewModel);


    }
}
