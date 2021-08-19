using MN_Groop_A.P.S.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.IServices
{
    public interface IKategoriServices
    {
        Task<List<Kategori>> GetAllkategoris();
        Task<Kategori> GetKategoriById(int id);
        Task<Kategori> Create(Kategori kategori);
        Task<Kategori> Update(int id, Kategori kategori);
        Task<Kategori> Delete(int id);
    }
}
