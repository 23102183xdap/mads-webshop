using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;

namespace MN_Groop_A.P.S.IRepositories
{
    public interface IKundeRepository
    {
        Task<List<Kunde>> GetAll();
        Task<Kunde> GetById(int id);
        Task<Kunde> Create(Kunde kunde);
        Task<Kunde> Update(int id, Kunde kunde);
        Task<Kunde> Delete(int id);
    }
}
