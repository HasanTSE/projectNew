using Microsoft.AspNetCore.Mvc;
using projectNew.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace projectNew.Controllers
{
    public class InformationController : Controller
    {
        private readonly dbContext _db;

        public InformationController(dbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            var infoList = _db.Infos.Include(p => p.Nation).ToList();
            var infoList1 = _db.Infos.Include(p => p.Gender).ToList();
            return View(infoList);
            return View(infoList1);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = _db.Infos.FirstOrDefault(x => x.Id == id);


            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);

        }

        public IActionResult Create()
        {
            ViewData["NationId"] = new SelectList(_db.Nations.Where(a => a.IsActive == true), "Id", "NationName");
            ViewData["GenderId"] = new SelectList(_db.Genders, "Id", "GenderName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Info dataPass)
        {
            if (dataPass != null && ModelState.IsValid)
            {
                _db.Add(dataPass);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewData["NationId"] = new SelectList(_db.Nations.Where(a => a.IsActive == true), "Id", "NationName");
            ViewData["GenderId"] = new SelectList(_db.Genders, "Id", "GenderName");
            return View(dataPass);
        }

        public IActionResult Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var employee = _db.Infos.FirstOrDefault(x => x.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["NationId"] = new SelectList(_db.Nations.Where(a => a.IsActive == true || a.Id==employee.NationId), "Id", "NationName", employee.NationId);
            ViewData["GenderId"] = new SelectList(_db.Genders, "Id", "GenderName");
            return View(employee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]


        public IActionResult Edit(Info employee)
        {
            if (employee == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(employee);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewData["NationId"] = new SelectList(_db.Nations, "Id", "NationName", employee.NationId);
            ViewData["GenderId"] = new SelectList(_db.Genders, "Id", "GenderName", employee.GenderId);
            return View(employee);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = _db.Infos.FirstOrDefault(x => x.Id == id);
            _db.Infos.Remove(employee);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }



    }
}
