using Microsoft.AspNetCore.Mvc;
using PhoneStore.DAL;
using PhoneStore.Domain;

namespace PhoneStore.Controllers
{
    public class BuyController : Controller
    {
        PhoneDbContext _db;

        public BuyController(PhoneDbContext db)
        {
            _db = db;
        }



        [HttpGet]
        public IActionResult GetBuy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.PhoneId = id;
            return View();
        }

        [HttpPost]
        public string GetBuy(Purchase purchase)
        {

            //Добавляем в бд заказ
            _db.Purchase.Add(purchase);

            // сохраняем в бд все изменения
            _db.SaveChanges();
            return "Спасибо, " + purchase.FIO + ", за покупку!";
        }
    }
}
