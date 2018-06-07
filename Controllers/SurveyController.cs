using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet]
        [Route("main")]
        public IActionResult Main()
        {
            return View();
        }
        //---------------*divider*--------------//
        [HttpPost]
        [Route("results")]
        public IActionResult Results(string ThisName, string DojoLocation, string FavoriteLanguage, string TheseComments)
        {
            ViewBag.Name = ThisName;
            ViewBag.Location = DojoLocation;
            ViewBag.Language = FavoriteLanguage;
            ViewBag.Comments = TheseComments;
            return View();
        }
    }
}