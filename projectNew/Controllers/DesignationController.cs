using Microsoft.AspNetCore.Mvc;
using projectNew.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace projectNew.Controllers
{
    public class DesignationController : Controller
    {
        private readonly dbContext _db;

        public DesignationController(dbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            var DesignationList = _db.Desigs.ToList();
            return View(DesignationList);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var designations = _db.Desigs.FirstOrDefault(x => x.Id == id);


            if (designations == null)
            {
                return NotFound();
            }
            return View(designations);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Desig dataPass)
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
            var designations = _db.Desigs.FirstOrDefault(x => x.Id == id);
            if (designations == null)
            {
                return NotFound();
            }

            return View(designations);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]


        public IActionResult Edit(Desig designations)
        {
            if (designations == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(designations);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(designations);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var designations = _db.Desigs.FirstOrDefault(x => x.Id == id);
            _db.Desigs.Remove(designations);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

    }
}
