using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using exocortex.Models;
using exocortex.Models.exocortex;

namespace exocortex.Controllers
{
    public class EntriesController : Controller
    {
        private ExocortexDbContext _context;

        public EntriesController(ExocortexDbContext context)
        {
            _context = context;    
        }

        // GET: Entries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Entries.ToListAsync());
        }

        // GET: Entries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Entry entry = await _context.Entries.SingleAsync(m => m.Id == id);
            if (entry == null)
            {
                return HttpNotFound();
            }

            return View(entry);
        }

        // GET: Entries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Entries/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Entry entry)
        {
            if (ModelState.IsValid)
            {
                _context.Entries.Add(entry);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(entry);
        }

        // GET: Entries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Entry entry = await _context.Entries.SingleAsync(m => m.Id == id);
            if (entry == null)
            {
                return HttpNotFound();
            }
            return View(entry);
        }

        // POST: Entries/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Entry entry)
        {
            if (ModelState.IsValid)
            {
                _context.Update(entry);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(entry);
        }

        // GET: Entries/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Entry entry = await _context.Entries.SingleAsync(m => m.Id == id);
            if (entry == null)
            {
                return HttpNotFound();
            }

            return View(entry);
        }

        // POST: Entries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Entry entry = await _context.Entries.SingleAsync(m => m.Id == id);
            _context.Entries.Remove(entry);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
