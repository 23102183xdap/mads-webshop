using MN_Groop_A.P.S.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.IServices
{
    public interface IKundeServices
    {
        Task<List<Kunde>> GetAllKundes();
        Task<Kunde> GetKundeById(int id);
        Task<Kunde> Create(Kunde kunde);
        Task<Kunde> Update(int id, Kunde kunde);
        Task<Kunde> Delete(int id);
    }
}
