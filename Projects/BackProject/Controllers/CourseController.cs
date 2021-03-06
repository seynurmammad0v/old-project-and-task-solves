using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackProject.DAL;
using BackProject.Extentions;
using BackProject.Models;
using BackProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackProject.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        public CourseController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                List<Course> courses = _context.Courses.Where(c => !c.IsDeleted && c.Activeted).OrderByDescending(c => c.Created_at).Take(9).ToList();
                return View(courses);
            }
            else
            {
                List<CourseCategory> courseCategories = _context.CourseCategories.Where(c => c.Activeted && !c.IsDeleted && c.CategoryId== id).Include(c => c.Course).ToList();
                List<Course> courses = new List<Course>();
                foreach (CourseCategory item in courseCategories)
                {
                    courses.Add(item.Course);
                }
                return View(courses);
            }

        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _context.Courses.Where(c => !c.IsDeleted && c.Activeted && c.Id == id).FirstOrDefaultAsync();
            if (course == null) return NotFound();

            _context.IncludeCategory(true);

            List<Course> lastestCourse = _context.Courses.Where(c => !c.IsDeleted && c.Activeted).OrderByDescending(c => c.Created_at).Take(3).ToList();

            _context.IncludeModerators(true);

            List<Tag> tags = _context.GetTags();

            CourseVM courseVM = new CourseVM()
            {
                Course = course,
                LastestCourse = lastestCourse,
                Tags = tags
            };
            return View(courseVM);
        }
        public IActionResult Search(string val)
        {
            List<Course> model = _context.Courses.Where(c => !c.IsDeleted && c.Activeted && c.Name.Contains(val)).OrderByDescending(c => c.Created_at).Take(10).ToList();
            return PartialView("_SearchPartialCourse", model);
        }
    }
}