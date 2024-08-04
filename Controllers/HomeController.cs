using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{

    public class HomeController : Controller
    {

        public IActionResult Results()
        {
            return View();
        }

        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            int userCount = Repository.Users.Where(user => user.WillAttend == true).Count();
            // ViewBag.Selamlama = saat > 12 ? "Iyi gunler" : "Gunaydin";
            // ViewBag.Isim = "Ercan Bey";

            ViewData["Selamlama"] = saat > 12 ? "Iyi gunler" : "Gunaydin";


            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Istanbul, Abc Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = userCount

            };


            return View(meetingInfo);
        }
    }
}