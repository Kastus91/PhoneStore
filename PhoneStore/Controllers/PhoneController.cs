using Microsoft.AspNetCore.Mvc;
using PhoneStore.DAL;
using System.Linq;

namespace PhoneStore.Controllers
{
    public class PhoneController : Controller
    {
        PhoneDbContext _db;

        public PhoneController(PhoneDbContext db)
        {
            _db = db;
        }



        public IActionResult GetPhone()
        {
            return View(_db.Phones.ToList());
        }
    }
}
