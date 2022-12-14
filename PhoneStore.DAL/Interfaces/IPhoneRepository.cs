using PhoneStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.DAL.Interfaces
{
    public interface IPhoneRepository: IBaseRepository<Phone>
    {
        Phone GetByName(string name);
    }
}
