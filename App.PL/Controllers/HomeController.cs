using App.PL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using App.DAL.Models;
using App.BLL.Services.Contracts;
namespace App.PL.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsersServices _userservices;

        public HomeController(IUsersServices userservices)
        {
            _userservices= userservices;
        }

        public async Task<IActionResult> Index() {

            List<User> listUsers = await _userservices.GetUsers();
            return View(listUsers);
        }
        public async Task<IActionResult> User()
        {
            List<User>listUsers =await _userservices.GetUsers();
            return View(listUsers);
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