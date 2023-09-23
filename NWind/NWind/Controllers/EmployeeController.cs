using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NWind.Models;

namespace NWind.Controllers
{
    public class EmployeeController : Controller
    {
        private RepositoryEmployee _repositoryEmployee;
        public  EmployeeController(RepositoryEmployee repository)
        {
            _repositoryEmployee= repository;
        }
        // GET: EmployeeCiontroller
        public ActionResult Index()
        {
            List<Employee> employees = _repositoryEmployee.AllEmployee();
            return View(employees);
        }
       
        // GET: EmployeeCiontroller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeCiontroller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeCiontroller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeCiontroller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeCiontroller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeCiontroller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeCiontroller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
