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
            var infoList = _db.Infos.Include(p => p.Nation)
                .Include(p => p.Gender)
                .Include(p => p.PresentDistrict)
                .Include(p => p.ParmanentDistrict)
                .Include(p => p.BloodGroup)
                .ToList();

                return View(infoList);
          
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
            ViewData["PresentDistrictId"] = new SelectList(_db.PreDistricts, "Id", "PresentDistrict");
            ViewData["ParmanentDistrictId"] = new SelectList(_db.ParDistricts, "Id", "ParmanentDistrict");
            ViewData["BloodGroupId"] = new SelectList(_db.Bloods, "Id", "BloodGroup");
            ViewData["CompanyId"] = new SelectList(_db.Compas.Where(a => a.IsActive == true), "Id", "Company");
            ViewData["DepartmentId"] = new SelectList(_db.Depts.Where(a => a.IsActive == true), "Id", "Department");
            ViewData["DesignationId"] = new SelectList(_db.Desigs.Where(a => a.IsActive == true), "Id", "Designation");
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
            ViewData["GenderId"] = new SelectList(_db.Genders, "Id", "GenderName");//Gender=GenderId ViewData["Gender"]==edit dekhabe
            ViewData["PresentDistrictId"] = new SelectList(_db.PreDistricts, "Id", "PresentDistrict");
            ViewData["ParmanentDistrictId"] = new SelectList(_db.ParDistricts, "Id", "ParmanentDistrict");
            ViewData["BloodGroupId"] = new SelectList(_db.Bloods, "Id", "BloodGroup");
            ViewData["CompanyId"] = new SelectList(_db.Compas.Where(a => a.IsActive == true), "Id", "Company");
            ViewData["DepartmentId"] = new SelectList(_db.Depts.Where(a => a.IsActive == true), "Id", "Department");
            ViewData["DesignationId"] = new SelectList(_db.Desigs.Where(a => a.IsActive == true), "Id", "Designation");
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
            ViewData["PresentDistrictId"] = new SelectList(_db.PreDistricts, "Id", "PresentDistrict");
            ViewData["ParmanentDistrictId"] = new SelectList(_db.ParDistricts, "Id", "ParmanentDistrict");
            ViewData["BloodGroupId"] = new SelectList(_db.Bloods, "Id", "BloodGroup");
            ViewData["CompanyId"] = new SelectList(_db.Compas.Where(a => a.IsActive == true), "Id", "Company");
            ViewData["DepartmentId"] = new SelectList(_db.Depts.Where(a => a.IsActive == true), "Id", "Department");
            ViewData["DesignationId"] = new SelectList(_db.Desigs.Where(a => a.IsActive == true), "Id", "Designation");
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
            //ViewData["GenderId"] = new SelectList(_db.Genders, "Id", "GenderName", employee.GenderId);
            ViewData["GenderId"] = new SelectList(_db.Genders, "Id", "GenderName", employee.GenderId);
            ViewData["PresentDistrictId"] = new SelectList(_db.PreDistricts, "Id", "PresentDistrict");
            ViewData["ParmanentDistrictId"] = new SelectList(_db.ParDistricts, "Id", "ParmanentDistrict");
            ViewData["BloodGroupId"] = new SelectList(_db.Bloods, "Id", "BloodGroup");
            ViewData["CompanyId"] = new SelectList(_db.Compas.Where(a => a.IsActive == true), "Id", "Company");
            ViewData["DepartmentId"] = new SelectList(_db.Depts.Where(a => a.IsActive == true), "Id", "Department");
            ViewData["DesignationId"] = new SelectList(_db.Desigs.Where(a => a.IsActive == true), "Id", "Designation");

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
