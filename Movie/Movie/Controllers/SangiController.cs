using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCA.Controllers
{
    public class SangiController : Controller
    {
        // GET: SangiController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SangiController/Details/5
        public ActionResult Tabs()
        {
            ViewData["data1"] = "Kokushibo and Yorichi are brothers";
            return View();
        }

    }
}
