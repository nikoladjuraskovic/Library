using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "Welcome to the Library!";
        }
    }
}
