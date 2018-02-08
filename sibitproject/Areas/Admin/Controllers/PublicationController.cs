using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sibitproject.Models;
using Microsoft.EntityFrameworkCore;

namespace sibitproject.Areas.Admin.Controllers
{
    public class PublicationController : Controller
    {
        private BaseContext _context;

        public PublicationController(BaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.News.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(News news)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(news);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? Id)
        {
            News news = await _context.News.FirstOrDefaultAsync(n => n.Id == Id);
            if (news != null)
            {
                _context.Remove(news);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}