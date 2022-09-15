using Microsoft.AspNetCore.Mvc;
using PhoneStore.DAL;
using PhoneStore.DAL.Interfaces;
using PhoneStore.Domain;
using PhoneStore.Service.Interfaces;

namespace PhoneStore.Controllers
{
    public class BuyController : Controller
    {
        private readonly IPurchaseService _purchaseService;

        public BuyController(IPurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }

        [HttpGet]
        public IActionResult GetBuy(int id)
        {
            

            var response = _purchaseService.GetPurchase(id);

            return View(response);
        }

        [HttpPost]
        public string GetBuy(Purchase purchase)
        {
           
            //Добавляем в бд заказ
            _purchaseService.CreatePurchase(purchase);

            
            
            return "Спасибо, " + purchase.FIO + ", за покупку!";
        }
    }
}
