using Microsoft.AspNetCore.Mvc;
using PegawaiMVC.Data;
using PegawaiMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace PegawaiMVC.Controllers
{
    public class PegawaiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PegawaiController(ApplicationDbContext context)
        {
            _context = context;
        }

        //READ(List Data)
        public async Task<IActionResult> Index()
        {
            var data = await _context.Pegawais.ToListAsync();
            return View(data);
        }

        //CREATE (Form)
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Pegawai pegawai)
        {
            if(ModelState.IsValid)
            {
                _context.Add(pegawai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pegawai);
        }

        //UPDATE (Form Edit)
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null) return NotFound();

            var pegawai = await _context.Pegawais.FindAsync(id);
            if (pegawai == null) return NotFound();

            return View(pegawai);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Pegawai pegawai)
        {
            if(id != pegawai.Id) return NotFound();

            if(ModelState.IsValid)
            {
                _context.Update(pegawai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pegawai);
        }

        //DELETE (Konfirmasi)
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null) return NotFound();

            var pegawai = await _context.Pegawais.FirstOrDefaultAsync(m => m.Id == id);
            if (pegawai == null) return NotFound();

            return View(pegawai);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pegawai = await _context.Pegawais.FindAsync(id);
            if(pegawai != null)
            {
                _context.Pegawais.Remove(pegawai);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }


        //DETAIL (Lihat 1 data)
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null) return NotFound();

            var pegawai = await _context.Pegawais.FirstOrDefaultAsync(m => m.Id == id);
            if (pegawai == null) return NotFound();

            return View(pegawai);
        }

    }
}