
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {

        [HttpGet]
        public IActionResult Apply()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Apply(UserInfo modelOfUserInfo)
        {
            if (ModelState.IsValid)
            {
                Repository.CreateUser(modelOfUserInfo);
                ViewBag.UserCount = Repository.Users.Where(user => user.WillAttend == true).Count();
                return View("Thanks", modelOfUserInfo);
            }
            else
            {
                return View(modelOfUserInfo);
            }

        }

        [HttpGet]
        public IActionResult List()
        {
            var users = Repository.Users;
            return View(users);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }

    }
}