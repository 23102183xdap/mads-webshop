using MN_Groop_A.P.S.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.IServices
{
    public interface ILoginServices
    {
        Task<List<Login>> GetAllLogins();
        Task<Login> GetLoginById(int id);
        Task<Login> Create(Login login);
        Task<Login> Update(int id, Login login);
        Task<Login> Delete(int id);
        Task<Login> IsAdmin(int id);
    }
}
