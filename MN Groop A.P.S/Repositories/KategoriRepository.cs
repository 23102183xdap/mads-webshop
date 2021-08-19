using MN_Groop_A.P.S.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.Database;
using Microsoft.EntityFrameworkCore;
using MN_Groop_A.P.S.IRepositories;

namespace MN_Groop_A.P.S.Repositories
{
    public class KategoriRepository : IKategoriRepository
    {
        private readonly MNGroupDBConktext _context;
        public KategoriRepository(MNGroupDBConktext context)
        {
            _context = context;
        }
        public async Task<List<Kategori>> GetAll()
        {
            return await _context.Kategori
                .Where(a => a.DelitedAt == null)
                .Include(a => a.Produkts)
                .ToListAsync();

        }
        public async Task<Kategori> GetById(int id)
        {
            return await _context.Kategori
                .Where(a => a.DelitedAt == null)
                .Include(a => a.Produkts)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<Kategori> Create(Kategori kategori)
        {    
            kategori.CreateAt = DateTime.Now;
            _context.Kategori.Add(kategori);
            await _context.SaveChangesAsync();
            return kategori;
           
        }
        public async Task<Kategori> Update(int id, Kategori kategori)
        {
            var editKategori = await _context.Kategori.FirstOrDefaultAsync(a => a.Id == id);
            if (editKategori != null)
            {
                editKategori.UpdatetAt = DateTime.Now;
                editKategori.Title = kategori.Title;
                editKategori.Beskrivelse = kategori.Beskrivelse;
                _context.Kategori.Update(editKategori);
                await _context.SaveChangesAsync();
            }
            return editKategori;
        }
        public async Task<Kategori> Delete(int id)
        {
            var kategori = await _context.Kategori.FirstOrDefaultAsync(a => a.Id == id);
            if (kategori != null)
            {
                kategori.DelitedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }
            return kategori;
        }

    }
}
