using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectD.Models;

namespace ProjectD.Controllers
{
    public class EMPLcontroller : Controller
    {
        // GET: EMPLcontroller
        public ActionResult Index()
        {
            List<Employee> employeesList = new List<Employee>();
            return View();
        }

        // GET: EMPLcontroller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EMPLcontroller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EMPLcontroller/Create
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

        // GET: EMPLcontroller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EMPLcontroller/Edit/5
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

        // GET: EMPLcontroller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EMPLcontroller/Delete/5
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
