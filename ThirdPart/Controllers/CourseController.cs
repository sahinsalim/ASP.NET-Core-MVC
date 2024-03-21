using Microsoft.AspNetCore.Mvc;
using ThirdPart.Models;

namespace ThirdPart.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
            //return View();
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate model)
        {
            if (Repository.Applications.Any(c=> c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("", "There is already aplication for this user.");
            }

            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return View("Feedback", model);
            }
            return View();
            
        }
    }
}
