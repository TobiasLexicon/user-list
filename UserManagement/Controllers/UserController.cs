using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Data;
using UserManagement.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserManagement.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //UserViewModel user = new()
            //{
            //    Name = "Tristan",
            //    Password = "123Gut",
            //    Language = Models.Language.Swedish
            //};

            //UserViewModel user = new()
            //{
            //    Name = DataRepository.GetUser().Name,
            //    Password = DataRepository.GetUser().Password,
            //    Language = DataRepository.GetUserPreferences().Language
            //};

            List<UserViewModel> allUsers = new()
            {
                new UserViewModel(DataRepository.users[0].Name, DataRepository.users[0].Password, DataRepository.usersPreferences[0].Language),
                new UserViewModel(DataRepository.users[1].Name, DataRepository.users[1].Password, DataRepository.usersPreferences[1].Language),
                new UserViewModel(DataRepository.users[2].Name, DataRepository.users[2].Password, DataRepository.usersPreferences[2].Language),
            };

            return View(allUsers);
        }

        public IActionResult GetAllUsers()
        {
            List<UserViewModel> allUsers = new()
            {
                new UserViewModel(DataRepository.users[0].Name, DataRepository.users[0].Password, DataRepository.usersPreferences[0].Language),
                new UserViewModel(DataRepository.users[1].Name, DataRepository.users[1].Password, DataRepository.usersPreferences[1].Language),
                new UserViewModel(DataRepository.users[2].Name, DataRepository.users[2].Password, DataRepository.usersPreferences[2].Language),
            };

            return View("_userList", allUsers);
        }
    }
}

