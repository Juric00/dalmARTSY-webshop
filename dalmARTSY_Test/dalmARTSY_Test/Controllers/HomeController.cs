using dalmARTSY_Test.Data;
using dalmARTSY_Test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using dalmARTSY_Test.Areas.Identity.Data;

namespace dalmARTSY_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _appDbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public IActionResult Index(string? searchQuery, int? orderBy)
        {
            List<Product> products = _appDbContext.Products.ToList();
            Random randomOrder = new Random();
            products = products.OrderBy(p => randomOrder.Next()).ToList();

            if (!String.IsNullOrWhiteSpace(searchQuery))
            {
                products = products.Where(p=>p.Title.ToLower().Contains(searchQuery.ToLower())).ToList();
            }

            switch (orderBy)
            {
                case 1: products = products.OrderBy(p => p.Title).ToList(); break;
                case 2: products = products.OrderByDescending(p => p.Title).ToList(); break;
                case 3: products = products.OrderBy(p => p.Price).ToList(); break;
                case 4: products = products.OrderByDescending(p => p.Price).ToList(); break;
                default:break;       
            }

            List<Product> tenProducts = products.Take(10).ToList();

            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> ProductDetails(int? id)
        {
            if (id == null || _appDbContext.Products == null)
            {
                return NotFound();
            }

            var product = await _appDbContext.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}