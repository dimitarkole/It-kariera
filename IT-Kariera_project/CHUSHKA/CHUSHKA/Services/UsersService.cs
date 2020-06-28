using CHUSHKA.Data.Entities;
using CHUSHKA.Models.User;
using CHUSHKA.Services.Contracts;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHUSHKA.Services
{
    public class UsersService : IUsersService
    {
        //private readonly SignInManager<User> singInManager;
        //private readonly UserManager<User> userManager;

        //public UserService(SignInManager<User> singInManager, UserManager<User> userMenager)
        //{
        //    this.singInManager = singInManager;
        //    this.userManager = userMenager;
        //}

        //public async Task<bool> Login(LoginUserViewModel model)
        //{
        //    var user = this.GetUser(model.Username).Result;
        //    if (user == null)
        //    {
        //        return false;
        //    }

        //    var result = await this.singInManager.PasswordSignInAsync(user, model.Password, isPersistent: false, lockoutOnFailure: false);

        //    return result.Succeeded;
        //}

        //public async Task<bool> RegisterNewUserAsync(RegisterUserViewModel model)
        //{

        //    User user = new User
        //    {
        //        UserName = model.Username,
        //        Email = model.Email,
        //        FullName = model.FullName
        //    };

        //    var userCreateResult = await this.userManager.CreateAsync(user, model.Password);

        //    if (!userCreateResult.Succeeded)
        //    {
        //        return false;
        //    }

        //    if (this.userManager.Users.Count()==1)
        //    {

        //       await  this.userManager.AddToRoleAsync(user, "Admin");
        //    }
        //    else
        //    {
        //        await this.userManager.AddToRoleAsync(user, "User");
        //    }
        //    return true;
        //}

        //public async Task<User> GetUser(string username)
        //{
        //    var user = await this.userManager.FindByNameAsync(username);
        //    return user;
        //}

        //public async void Logout()
        //{
        //    await this.singInManager.SignOutAsync();
        //}

        private readonly SignInManager<User> singInManager;
        private readonly UserManager<User> userManager;

        public UsersService(SignInManager<User> singInManager, UserManager<User> userManager)
        {
            this.singInManager = singInManager;
            this.userManager = userManager;
        }
               
        public async Task<bool> Login(LoginUserViewModel model)
        {
            var user = this.GetUser(model.Username).Result;
            if (user == null)
            {
                return false;
            }

            var result = await this.singInManager.PasswordSignInAsync(user, model.Password, isPersistent: false, lockoutOnFailure: false);

            return result.Succeeded;
        }


        public async Task<bool> RegisterNewUser(RegisterUserViewModel model)
        {
            if (model.Username == null ||
                model.Password == null ||
                model.ConfirmPassword == null ||
                model.Email == null ||
                model.FullName == null)
            {
                return false;
            }

            if (model.Password != model.ConfirmPassword)
            {
                return false;
            }

            var user = new User
            {
                UserName = model.Username,
                Email = model.Email,
                FullName = model.FullName
            };

            var userCreateResult = await this.userManager.CreateAsync(user, model.Password);
            

            if (!userCreateResult.Succeeded)
            {
                return false;
            }

            IdentityResult addRoleResult = null;

            if (this.userManager.Users.Count() == 1)
            {
                addRoleResult = await this.userManager.AddToRoleAsync(user, "Admin");
            }
            else
            {
                addRoleResult = await this.userManager.AddToRoleAsync(user, "User");
            }

            if (!addRoleResult.Succeeded)
            {
                return false;
            }
            return true;
        }



        public async Task<User> GetUser(string username)
        {
            var user = await this.userManager.FindByNameAsync(username);
            return user;
        }

        public async void Logout()
        {
            await this.singInManager.SignOutAsync();

        }

    }
}
