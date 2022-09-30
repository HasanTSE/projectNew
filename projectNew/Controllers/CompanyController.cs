using Microsoft.AspNetCore.Mvc;
using projectNew.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace projectNew.Controllers
{
    public class CompanyController : Controller
    {
        private readonly dbContext _db;

        public CompanyController(dbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            var companyList = _db.Compas.ToList();
            return View(companyList);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var companies = _db.Compas.FirstOrDefault(x => x.Id == id);


            if (companies == null)
            {
                return NotFound();
            }
            return View(companies);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Compa dataPass)
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
            var companies = _db.Compas.FirstOrDefault(x => x.Id == id);
            if (companies == null)
            {
                return NotFound();
            }

            return View(companies);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]


        public IActionResult Edit(Compa companies)
        {
            if (companies == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(companies);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(companies);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var companies = _db.Compas.FirstOrDefault(x => x.Id == id);
            _db.Compas.Remove(companies);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }


    }
}
