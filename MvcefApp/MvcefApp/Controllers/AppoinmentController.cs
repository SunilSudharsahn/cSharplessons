using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcefApp.Models;

namespace MvcefApp.Controllers
{
    public class AppoinmentController : Controller
    {
        // GET: AppoinmentController
        public ActionResult Index()
        {

            List<Appoinment> appoinments = RepositoryAppoinment.GetAppoinment();
            
            if (appoinments != null && appoinments.Count > 0)
                return View(appoinments);

            else
                return RedirectToAction("Create");

        }

        // GET: AppoinmentController/Details/5
        public ActionResult Details(int id)
        {
            Appoinment  appoinment = RepositoryAppoinment.GetAppoinment(id);

            return View();
        }

        // GET: AppoinmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppoinmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Appoinment   appoinment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryAppoinment.AddAppoinment(appoinment);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception err)
            {
                return View();
            }
        }

        // GET: AppoinmentController/Edit/5
        public ActionResult Edit(int id)
        {
            Appoinment appoinment = RepositoryAppoinment.GetAppoinment(id);
            return View();
        }

        // POST: AppoinmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Appoinment appoinment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryAppoinment.ModifyAppointment(appoinment);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AppoinmentController/Delete/5
        public ActionResult Delete(int id)
        {
            Appoinment  appoinment = RepositoryAppoinment.GetAppoinment(id);
            return View();
        }

        // POST: AppoinmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection,Appoinment appoinment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryAppoinment.RemoveAppoinment(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
