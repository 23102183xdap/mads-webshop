    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MN_Groop_A.P.S.Database;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IRepositories;

namespace MN_Groop_A.P.S.Repositories
{
    public class ProduktRepository : IProduktRepository
    {
        private readonly MNGroupDBConktext _context;
        public ProduktRepository(MNGroupDBConktext context)
        {
            _context = context;
        }
        public async Task<List<Produkt>> GetAll()
        {
            return await _context.Produkt
                .Where(a => a.DelitedAt == null)
                .Include(a=> a.Kategori)
                .ToListAsync();
        }

        public async Task<Produkt> GetById(int id)
        {
            return await _context.Produkt
                .Where(a => a.DelitedAt == null)
                .Include(a => a.Kategori)
                .FirstOrDefaultAsync(a => a.Id == id);
        }
        public async Task<Produkt> Create(Produkt produkt)
        {
            produkt.CreateAt = DateTime.Now;
            _context.Produkt.Add(produkt);
            await _context.SaveChangesAsync();
            return produkt;
        }
        public async Task<Produkt> Update(int id, Produkt produkt)
        {
            var editProdukt = await _context.Produkt.FirstOrDefaultAsync(a => a.Id == id);
            if (editProdukt != null)
            {
                editProdukt.UpdatetAt = DateTime.Now;
                editProdukt.Name = produkt.Name;
                editProdukt.Beskrivelse = produkt.Beskrivelse;
                editProdukt.Pris = produkt.Pris;
                _context.Produkt.Update(editProdukt);
                await _context.SaveChangesAsync();
            }
            return editProdukt;
        }

        public async Task<Produkt> Delete(int id)
        {
            var produkt = await _context.Produkt.FirstOrDefaultAsync(a => a.Id == id);
            if (produkt != null)
            {
                produkt.DelitedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }
            return produkt;
        }

    }
}
