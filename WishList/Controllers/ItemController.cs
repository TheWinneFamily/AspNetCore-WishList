using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View("Index", _context.Items.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            //public\s*IActionResult\s*Delete\s*?[(]\s*?int\s*id\s*?[)]\s*?{\s*?.*
            Item item = _context.Items.FirstOrDefault(i=> i.Id == id);
            //_context.Items.FirstOrDefault[(].*[.]Id\s*?==\s*?id\s*?[)];\s*?
            _context.Items.Remove(item);
            //_context([.]Items)?[.]Remove[(]\s*?.*\s*?[)];\s*?
            _context.SaveChanges();
            //_context[.]SaveChanges[(]\s*?[)];\s*?
            return RedirectToAction("Index");
            //return\s*RedirectToAction[(]""Index""(,\s*?""Item"")?[)];\s*?}";
        }
    }
}
