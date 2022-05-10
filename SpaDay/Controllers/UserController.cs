using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
      
        [HttpPost("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {           
            // form submission handling
            ViewBag.user = newUser;
            ViewBag.error = "Error: passwords do not match.";//error message is only set after the post request
            
            return newUser.Password == verify ? View("Index") : View("Add");//rewritten with ternary
        }
    }
}