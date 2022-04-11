using Microsoft.AspNetCore.Mvc;

namespace Portfolio_1.Controllers
{
    public class FirstController : Controller
    {
        // What type of route are we working with?
        [HttpGet]
        //We tell it what the name of the route is
        [Route("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        [Route("Second")]
        public ViewResult Second()
        {
            return View("Second");
        }

        [HttpGet]
        [Route("Third")]
        public ViewResult Third()
        {
            return View("Third");
        }
    }
}