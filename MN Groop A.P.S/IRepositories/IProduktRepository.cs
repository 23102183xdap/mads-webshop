using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;

namespace MN_Groop_A.P.S.IRepositories
{
    public interface IProduktRepository
    {
        Task<List<Produkt>> GetAll();
        Task<Produkt> GetById(int id);
        Task<Produkt> Create(Produkt produkt);
        Task<Produkt> Update(int id, Produkt produkt);
        Task<Produkt> Delete(int id);
    }
}
