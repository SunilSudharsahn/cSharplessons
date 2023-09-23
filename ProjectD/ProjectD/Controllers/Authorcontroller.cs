using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using ProjectD.Models;
using System.Security.Claims;

namespace ProjectD.Controllers
{
    public class AUTHORcontroller : Controller
    {
    

        // GET: AuthorController
        public ActionResult Index()
        {
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            if (list != null && list.Count>0)
            {
                return View("AuthorList", list.Values.ToList());
            }
            return View();
        }

      





        // GET: AuthorController/Details/5
        public ActionResult Details(int id)
        {
            Author author = AuthorRepository.FindAuthotByID(id);
            if (author != null)
            {
                return View(author);
            }
            return RedirectToAction("Index");
        }



        // GET: AuthorController/Create
        public ActionResult Create()
        {
            Author author=new Author();
            return View(author);
        }



        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Author pAuthor)
        {
            try
            {
                AuthorRepository.SaveToFile(pAuthor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }



        // POST: AuthorController/Edit/5
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



        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }



        // POST: AuthorController/Delete/5
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
