using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;

namespace MN_Groop_A.P.S.IRepositories
{
    public interface ILoginRepository
    {
        Task<List<Login>> GetAll();
        Task<Login> GetById(int id);
        Task<Login> Create(Login login);
        Task<Login> Update(int id, Login login);
        Task<Login> Delete(int id);
        Task<Login> IsAdmin(int id);
    }
}
