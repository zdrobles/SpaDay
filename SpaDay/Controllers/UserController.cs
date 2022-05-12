using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModel;

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
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            // form submission handling
            if (!ModelState.IsValid) { return View("Add", addUserViewModel); }
            ViewBag.error = "Error: passwords do not match.";//error message is only set after the post request
            User newUser = new User
            {
                Username = addUserViewModel.Username,
                Password = addUserViewModel.Password,
                Email = addUserViewModel.Email,
            };
            return addUserViewModel.Password == addUserViewModel.VerifyPassword ? View("Index", newUser) : View("Add",  addUserViewModel);//rewritten with ternary
        }
    }
}