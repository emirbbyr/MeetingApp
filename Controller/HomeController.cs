using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
   public class HomeController : Controller
   {
      public IActionResult Index()
      {

         int saat = DateTime.Now.Hour;

         // ViewBag.Selamlama = saat >12 ? "İyi Günler": "Günaydın";
         // ViewBag.UserName ="Emirhan";

         ViewData["Selamlama"] = saat > 12 ? "İyi Günler" : "Günaydın";
         ViewData["UserName"] = "Emirhan";

         var meetingInfo = new MeetingInfo()
         {
            Id = 1,
            Location = "Abc Kongre merkezi",
            Date = new DateTime(2025, 01, 20, 20, 0, 0),
            NumberOfPeople = 199

         };

         return View(meetingInfo);
      }
   }
}
