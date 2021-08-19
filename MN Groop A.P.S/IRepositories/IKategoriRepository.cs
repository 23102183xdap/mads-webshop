using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;

namespace MN_Groop_A.P.S.IRepositories
{
    public interface IKategoriRepository
    {
        Task<List<Kategori>> GetAll();
        Task<Kategori> GetById(int id);
        Task<Kategori> Create(Kategori kategori);
        Task<Kategori> Update(int id, Kategori kategori);
        Task<Kategori> Delete(int id);

    }
}
