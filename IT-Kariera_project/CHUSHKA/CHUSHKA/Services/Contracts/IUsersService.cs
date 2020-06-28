using CHUSHKA.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHUSHKA.Services.Contracts
{
    public interface IUsersService
    {
        Task<bool> RegisterNewUser(RegisterUserViewModel model);
        Task<bool> Login(LoginUserViewModel model);
        void Logout();
    }
}
