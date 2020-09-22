using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CFLv2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CFLv2.Controllers
{
    public class StandingsController : Controller
    {
        private readonly CFLDBContext _context;

        public StandingsController(CFLDBContext context)
        {
            _context = context;
        }
        // GET: Standing
        public async Task<IActionResult> Index()
        {
            return View(await _context.Standings.ToListAsync());
        }

        public async Task<IActionResult> View_()
        {
            return View(await _context.Standings.ToListAsync());
        }
    }
}