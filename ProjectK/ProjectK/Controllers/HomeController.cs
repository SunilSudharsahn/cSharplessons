using Microsoft.AspNetCore.Mvc;
using ProjectK.Models;
using System.Configuration;
using System.Diagnostics;

namespace ProjectK.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Sayhello( string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                ViewData["v1"] = "Ena chithapa Epdi iruka";
            }
            else
            {
                ViewData["v1"] = name;
            }
            return View();
        }
        public IActionResult Add(int x, int y)
        {
            int result = x + y;
            ViewData["addResult"]=result;
            return View();
        }
        public IActionResult Multiply(int x, int y)
        {
            int result = x * y;
            ViewData["MultiplyResult"] = result;
            return View();
        }
        public IActionResult Divide(int x, int y)
        {
            int result = x / y;
            ViewData["DivideResult"] = result;
            return View();
        }
        public IActionResult DoLogin(string txtUser,string txtpwd)
        {
            ViewData["uservalue"]=$"{txtUser},{txtpwd}";
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddNewBook()
        {
            Book book = new Book(); 
            return View();
        }
        public IActionResult SaveNewBook(Book pbook)
        {
            string fName = @"C:\Users\sunilsudharshan.vm\Documents\bookex.txt";
            string strbook = $"{pbook.BookID},{pbook.Title},{pbook.AuthorName},{pbook.Cost}";
            using(StreamWriter sw = new StreamWriter(fName,true)) 
            {
            Console.WriteLine(strbook+Environment.NewLine);
            }
            return View(pbook);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}