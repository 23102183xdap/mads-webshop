using MN_Groop_A.P.S.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.IServices
{
    public interface IProduktServices
    {
        Task<List<Produkt>> GetAllProduktors();
        Task<Produkt> GetProduktById(int id);
        Task<Produkt> Create(Produkt produkt);
        Task<Produkt> Update(int id, Produkt produkt);
        Task<Produkt> Delete(int id);
    }
}
