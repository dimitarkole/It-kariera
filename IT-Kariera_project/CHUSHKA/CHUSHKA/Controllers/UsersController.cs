using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CHUSHKA.Models.User;
using CHUSHKA.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CHUSHKA.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService userService;

        public UsersController(IUsersService userService)
        {

            this.userService = userService;
        }
        [HttpGet]
        public IActionResult Register()
        {
            var model = new RegisterUserViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Register(RegisterUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if(this.userService.RegisterNewUser(model).Result)
            {
                return RedirectToAction(nameof(Login));
            }

            return this.View(model);
        }

        public IActionResult Login()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Login(LoginUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View();
            }
            var result = this.userService.Login(model);

            if (!result.Result)
            {
                return this.View();
            }
                       
            return this.Redirect("/");
        }

    }
}