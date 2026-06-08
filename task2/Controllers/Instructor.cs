using Microsoft.AspNetCore.Mvc;
using task2.Models;

namespace task2.Controllers
{
    public class InstructorController : Controller
    {
        CompanyDbContext DB = new CompanyDbContext();

        public IActionResult showall()
        {
            List<instructor> list_instructors = DB.Instructors.ToList();
            return View("showall", list_instructors);
        }
        public IActionResult showdetails(int id)
        {
            instructor instructor = DB.Instructors.FirstOrDefault(i => i.Id == id);
            if (instructor == null)
            {
                return NotFound();
            }
            return View("showdetails", instructor);
        }
    }
}
