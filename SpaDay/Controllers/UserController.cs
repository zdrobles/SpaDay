using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModel;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
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
            User newUser = new User
            {
                Username = addUserViewModel.Username,
                Password = addUserViewModel.Password,
                Email = addUserViewModel.Email,
            };
            return View("Index", newUser);
        }
    }
}