using Microsoft.AspNetCore.Mvc;
using PhoneStore.DAL.Interfaces;

namespace PhoneStore.Controllers
{
    public class BasketController1 : Controller
    {

        private readonly IBasketRepository _basketRepository;

        public BasketController1(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }

        public IActionResult GetBasket()
        {
            return View();
        }
    }
}
