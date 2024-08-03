
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Apply(UserInfo modelOfUserInfo)
        {

            return View();

        }

        [HttpGet]
        public IActionResult List()
        {
            return View();
        }

    }
}