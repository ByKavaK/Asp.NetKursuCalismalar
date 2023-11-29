using basics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace basics.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return Redirect("course/list");
            }
            
            var kurs = Repository.getById(id);

            return View(kurs);
        }

        public IActionResult List()
        {
            return View("CourseList", Repository.Courses);
        }
    }
}
