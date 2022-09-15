using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using PhoneStore.DAL;
using PhoneStore.DAL.Interfaces;
using PhoneStore.Domain;
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
            var responce = _phoneService.GetPhones();
           
            
            return View(responce);
            

            
        }
    }
}
