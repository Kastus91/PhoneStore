using PhoneStore.Domain.Responce;
using PhoneStore.Domain.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Service.Interfaces
{
    public interface IAccountService
    {
        Task Register (RegisterViewModel model);

        Task Login(LoginViewModel model);

        public void ChangePassword(ChangePasswordViewModel model);
        


    }
}
