using Microsoft.AspNetCore.Mvc;
using projectNew.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace projectNew.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly dbContext _db;

        public DepartmentController(dbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            var DepartmentList = _db.Depts.ToList();
            return View(DepartmentList);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var departments = _db.Depts.FirstOrDefault(x => x.Id == id);


            if (departments == null)
            {
                return NotFound();
            }
            return View(departments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Dept dataPass)
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
            var departments = _db.Depts.FirstOrDefault(x => x.Id == id);
            if (departments == null)
            {
                return NotFound();
            }

            return View(departments);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]


        public IActionResult Edit(Dept departments)
        {
            if (departments == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(departments);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(departments);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var departments = _db.Depts.FirstOrDefault(x => x.Id == id);
            _db.Depts.Remove(departments);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
