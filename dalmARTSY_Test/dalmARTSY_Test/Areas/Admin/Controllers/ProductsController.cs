using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dalmARTSY_Test.Data;
using dalmARTSY_Test.Models;
using Microsoft.AspNetCore.Authorization;
using System.Drawing;

namespace dalmARTSY_Test.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Products
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Products.Include(p => p.Category);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Admin/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Products/Create
        public IActionResult Create()
        {

            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title");

            ViewBag.ErrorMessage = TempData["ErrorMessage"] as string ?? ""; // Fail safe - ako ne postoji TempData, neka bude prazno "" ( ?? - nullable)

            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryId,Author,Title,Height,Width,Description,Frame,InStock,Price,ArtCode,Image")] Product product, int[] styleIds, IFormFile Image)
        {
            if(styleIds.Length==0 || styleIds==null)
            {
                TempData["ErrorMessage"] = "Choose one or more styles for your dalmARTSY art";
                return RedirectToAction(nameof(Create));
            }

            if (ModelState.IsValid)     //ModelState - svojstvo koje (Binda) mapira svojstva klase sa objektom/PARAMETROM iz Create akcije
            {
                try
                {
                    var getFileExtension = Path.GetExtension(Image.FileName);
                    var imageName = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + getFileExtension;

                    var saveImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products", imageName);

                    Directory.CreateDirectory(Path.GetDirectoryName(saveImagePath) ?? throw new ArgumentNullException(nameof(saveImagePath)));

                    using (var stream = new FileStream(saveImagePath, FileMode.Create))
                    {
                        Image.CopyTo(stream);
                    }

                    product.Image = imageName;

                }

                catch(Exception ex)
                {
                    TempData["Error Message"] = ex.Message;
                    return RedirectToAction(nameof(Create));
                }

                _context.Add(product);
                await _context.SaveChangesAsync();

                foreach (var styleId in styleIds)
                {
                    ProductStyle productStyle = new ProductStyle();
                    productStyle.StyleId = styleId;
                    productStyle.ProductId = product.Id;

                    _context.ProductStyles.Add(productStyle);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title", product.CategoryId);
            return View(product);

        }

        // GET: Admin/Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title", product.CategoryId);

            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryId,Author,Title,Height,Width,Description,Frame,InStock,Price,ArtCode,Image")] Product product, IFormFile? newImage, int[] styleIds)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title", product.CategoryId);
            return View(product);
        }

        // GET: Admin/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'AppDbContext.Products'  is null.");
            }
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
          return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
