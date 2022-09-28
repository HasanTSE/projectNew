using Microsoft.AspNetCore.Mvc;
using projectNew.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace projectNew.Controllers
{
    public class NationalityController : Controller
    {
        private readonly dbContext _db;
        public NationalityController(dbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var nationalityList = _db.Nations.ToList();
            return View(nationalityList);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var desh = _db.Nations.FirstOrDefault(x => x.Id == id);


            if (desh == null)
            {
                return NotFound();
            }
            return View(desh);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Nation dataPass)
        {
            if (dataPass != null && ModelState.IsValid)
            {
                _db.Add(dataPass);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
           
            return View(dataPass);
        }


        public IActionResult Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var desh = _db.Nations.FirstOrDefault(x => x.Id == id);
            if (desh == null)
            {
                return NotFound();
            }
            
            return View(desh);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]


        public IActionResult Edit(Nation desh)
        {
            if (desh == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(desh);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            
            return View(desh);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var desh = _db.Nations.FirstOrDefault(x => x.Id == id);
            _db.Nations.Remove(desh);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }


    }
}
