using PhoneStore.DAL.Interfaces;
using PhoneStore.Domain;
using PhoneStore.Domain.Enum;
using PhoneStore.Domain.Responce;
using PhoneStore.Service.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Service.Implementetions
{
    public class PhoneService : IPhoneService
    {
        private readonly IPhoneRepository _phoneRepository;

        public PhoneService(IPhoneRepository phoneRepository)
        {
            _phoneRepository = phoneRepository;
        }

        public IEnumerable<Phone> GetPhones()
        {
           
            var phones = _phoneRepository.GetAll();

            return phones;
                
        }





        /*public IEnumerable<Phone> GetAllPhones()
        {
            var phones = _phoneRepository.GetAll();

           return phones;
        }*/





        // public Phone GetPhone(int id)
        // {
        /*var baseResponce = new BaseResponse<Phone>();

        try
        {
            var phone = _phoneRepository.Get(id);
            if (phone == null)
            {
                baseResponce.Description = "Phone not found";
                baseResponce.StatusCode = (TaskStatus)StatusCode.PhoneNotFound;

            }

        }
        catch (Exception ex)
        {

            throw;
        }*/


        //}
    }
}
