using PhoneStore.DAL.Interfaces;
using PhoneStore.Domain;
using PhoneStore.Domain.Enum;
using PhoneStore.Domain.Responce;
using PhoneStore.Domain.ViewModels;
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

        public Phone GetPhone(int id)
        {
            var phone = _phoneRepository.Get(id);

            return phone;
        }


        public Phone GetPhoneByName(string name)
        {
            var phone = _phoneRepository.GetByName(name);

            return phone;
        }

       
        public bool CreatePhone(PhoneViewModel phoneViewModel)
        {

            try
            {
                var phone = new Phone()
                {

                    Name = phoneViewModel.Name,
                    Produce = phoneViewModel.Produce,
                    Price = phoneViewModel.Price,
                };

                _phoneRepository.Create(phone);

                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        
        
        
        public bool DeletePhone(int id)
        {
            try
            {
                var phone = _phoneRepository.Get(id);
                
                if (phone == null)
                {
                    bool result = true;

                    return result;
                }
                

                _phoneRepository.Delete(phone);
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }

        public Phone Edit(int id, PhoneViewModel phoneViewModel)
        {
            var phone = _phoneRepository.Get(id);
            
            phone.Name = phoneViewModel.Name;
            phone.Produce = phoneViewModel.Produce;
            phone.Price = phoneViewModel.Price;

            _phoneRepository.Update(phone);

            return phone;

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
