using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using PhoneStore.DAL;
using PhoneStore.DAL.Interfaces;
using PhoneStore.Domain;
using PhoneStore.Domain.ViewModels;
using PhoneStore.Service;
using PhoneStore.Service.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStore.Controllers
{
    public class PhoneController : Controller
    {

        private readonly IPhoneService _phoneService;

        public PhoneController(IPhoneService phoneService)
        {
            _phoneService = phoneService;
        }

        [HttpGet]
        public IActionResult GetPhone()
        {
            var response = _phoneService.GetPhones();
           
            
            return View(response);                      
        }

        [HttpGet]

        public IActionResult GetIdPhone(int id)
        {
            var response = _phoneService.GetPhone(id);

            return View(response);
        }

        [Authorize(Roles ="Admin")]
        public IActionResult Delete(int id)
        {
            var response = _phoneService.DeletePhone(id);

            return View(response);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Save(int id)
        {
            if (id == 0)
            {
                return View();
            }

            var response = _phoneService.GetPhone(id);

            return View(response);
        }

        [HttpPost]
        public IActionResult Save(PhoneViewModel phoneViewModel)
        {
            if (ModelState.IsValid )
            {
                if (phoneViewModel.PhoneId == 0)
                {
                    _phoneService.CreatePhone(phoneViewModel);
                }

                else
                {
                    _phoneService.Edit(phoneViewModel.PhoneId, phoneViewModel);
                }
            }

            return RedirectToAction("GetPhones");
        }
    }
}
