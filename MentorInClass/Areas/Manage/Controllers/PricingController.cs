using MentorInClass.DAL;
using MentorInClass.Models;
using MentorInClass.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorInClass.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Card> cards = _context.Cards.ToList();


            return View(cards);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Card card)
        {
            _context.Cards.Add(card);

            _context.SaveChanges();
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        
    }
}
