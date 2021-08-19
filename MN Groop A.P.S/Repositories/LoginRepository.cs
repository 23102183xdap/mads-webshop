using Microsoft.EntityFrameworkCore;
using MN_Groop_A.P.S.Database;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly MNGroupDBConktext _context;
        public LoginRepository(MNGroupDBConktext conktext)
        {
            _context = conktext;
        }
        public async Task<List<Login>> GetAll()
        {
            return await _context.Login
                 .Where(a => a.DelitedAt == null)
                 .ToListAsync();
        }

        public async Task<Login> GetById(int id)
        {
            return await _context.Login
                .Where(a => a.DelitedAt == null)
                .FirstOrDefaultAsync(a => a.Id ==id);

        }

        public async Task<Login> Create(Login login)
        {
            login.CreateAt = DateTime.Now;
            _context.Login.Add(login);
            await _context.SaveChangesAsync();
            return login;
        }


        public async Task<Login> Update(int id, Login login)
        {
            var editlogin = await _context.Login.FirstOrDefaultAsync(a => a.Id == id);
            if (editlogin != null)
            {
                editlogin.UpdatetAt = DateTime.Now;
                editlogin.Email = login.Email;
                editlogin.Password = login.Password;
                _context.Login.Update(editlogin);
                await _context.SaveChangesAsync();

            }
            return editlogin;
        }

        public async Task<Login> Delete(int id)
        {
            var login = await _context.Login.FirstOrDefaultAsync(a => a.Id == id);
            if (login != null)
            {
                login.DelitedAt = DateTime.Now;
                await _context.SaveChangesAsync();

            }
            return login;
        }

        public  Task<Login> IsAdmin(int id)
        {
            throw new NotImplementedException();
        }
    }
}
