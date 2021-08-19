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
    public class KundeRepository : IKundeRepository
    {
        private readonly MNGroupDBConktext _context;
        public KundeRepository(MNGroupDBConktext conktext)
        {
            _context = conktext;
        }
        public async Task<List<Kunde>> GetAll()
        {
            return await _context.Kunde
                .Where(a => a.DelitedAt == null)
               .Include(a => a.LoginId)
               .ToListAsync();
        }   
        public async Task<Kunde> GetById(int id)
        {
            return await _context.Kunde
                .Where(a => a.DelitedAt == null)
                .Include(a => a.LoginId)
                .FirstOrDefaultAsync(a => a.Id == id);
        }
        public async Task<Kunde> Create(Kunde kunde)
        {
            kunde.CreateAt = DateTime.Now;
            _context.Kunde.Add(kunde);
            await _context.SaveChangesAsync();
            return kunde;
        }
        public async Task<Kunde> Update(int id, Kunde kunde)
        {
            var editkunde = await _context.Kunde.FirstOrDefaultAsync(a => a.Id == id);
            if (editkunde != null)
            {
                editkunde.UpdatetAt = DateTime.Now;
                editkunde.FirstName = kunde.FirstName;
                editkunde.LastName = kunde.LastName;
                editkunde.VejNavn = kunde.VejNavn;
                editkunde.PostNummer = kunde.PostNummer;
                _context.Kunde.Update(editkunde);
                await _context.SaveChangesAsync();
            }
            return editkunde;
        }
        public async Task<Kunde> Delete(int id)
        {
            var kunde = await _context.Kunde.FirstOrDefaultAsync(a => a.Id == id);
            if (kunde != null)
            {
                kunde.DelitedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }
            return kunde;
        }

    }
}
