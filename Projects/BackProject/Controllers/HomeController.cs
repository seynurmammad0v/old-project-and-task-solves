using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BackProject.Models;
using BackProject.DAL;
using BackProject.ViewModels;
using BackProject.Extentions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BackProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Sliders> slider = _context.Sliders.Where(s => s.Activeted && !s.IsDeleted).ToList();
            List<Teacher> teachers = _context.Teachers.Where(t => !t.IsDeleted && t.Activeted).Take(4).OrderByDescending(teachers=>teachers.Id).ToList();
            List<Course> courses = _context.Courses.Where(c => !c.IsDeleted && c.Activeted).Take(3).OrderByDescending(c => c.Created_at).ToList();
            List<Event> @event = _context.Events.Where(e => !e.IsDeleted && e.Activeted).Take(4).ToList();
            List<Blog> blogs = _context.Blogs.Where(b => !b.IsDeleted && b.Activeted).Take(3).OrderByDescending(b => b.Created_at).ToList();
            _context.IncludeModeratorsBlog(true);
            AboutSection aboutSection = _context.AboutSections.FirstOrDefault();
            NoticeSection noticeSection = _context.NoticeSections.Include(n=>n.Notices).FirstOrDefault();
            List<TestimonialSection> testimonialSection = _context.TestimonialSections.ToList();

            HomeVM homeVM = new HomeVM()
            {
                Sliders = slider,
                Teachers = teachers,
                Courses = courses,
                Events = @event,
                Blogs= blogs,
                AboutSections=aboutSection,
                NoticeSections= noticeSection,
                TestimonialSections= testimonialSection

            };
            return View(homeVM);
        }
     
        public async Task<IActionResult> SendMsg(SendMessageFromUser userMesssage)
        {
            if (ModelState.IsValid)
            {
                _context.SendMessageFromUsers.Add(userMesssage);
                await _context.SaveChangesAsync();
                return Json("Success!");
            }
            string errors="";
            foreach(var item in ModelState.Values)
            {
                foreach (var error in item.Errors)
                {
                    errors += error.ErrorMessage;
                }
            }
            return Json(errors);
        }
        public async Task<IActionResult> Subscribe(SubscribedUsers sub)
        {
            if (ModelState.IsValid)
            {
                _context.SubscribedUsers.Add(sub);
                sub.ActiveCode = Guid.NewGuid().ToString();
                sub.Actived = true;
                await _context.SaveChangesAsync();
                return Json("Success!");
            }
            string errors = "";
            foreach (var item in ModelState.Values)
            {
                foreach (var error in item.Errors)
                {
                    errors += error.ErrorMessage;
                }
            }
            return Json(errors);
        }
    }
}
