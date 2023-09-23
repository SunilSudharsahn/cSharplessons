using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCA.Controllers
{
    public class CalculatorController1 : Controller
    {
        // GET: CalculatorController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: CalculatorController1/Details/5
        public int Add(int x,int y)
        {
            return x+y;
        }

         
    }
}
