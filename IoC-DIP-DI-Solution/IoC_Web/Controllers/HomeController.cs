using IoC_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IoC_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonDateService _singletonDateService;
        private readonly IScopedDateService _scopedDateService;
        private readonly ITransientDateService transientDateService;

        public HomeController(ISingletonDateService singletonDateService, IScopedDateService scopedDateService, ITransientDateService transientDateService)
        {
            _singletonDateService = singletonDateService;
            _scopedDateService = scopedDateService;
            this.transientDateService = transientDateService;
        }

        public IActionResult Index(
            [FromServices]ISingletonDateService singletonDate, 
            [FromServices] IScopedDateService scopedDate, 
            [FromServices] ITransientDateService transientDate)
        {
            ViewBag.time1 = _singletonDateService.GetDateTime.TimeOfDay;
            ViewBag.time2 = singletonDate.GetDateTime.TimeOfDay;

            ViewBag.time3 = _scopedDateService.GetDateTime.TimeOfDay;
            ViewBag.time4 = scopedDate.GetDateTime.TimeOfDay;

            ViewBag.time5 = transientDateService.GetDateTime.TimeOfDay;
            ViewBag.time6 = transientDate.GetDateTime.TimeOfDay;
            return View();
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
