using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IRepositories;
using MN_Groop_A.P.S.IServices;
using MN_Groop_A.P.S.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.services
{
    public class KategoriServices : IKategoriServices
    {
        private readonly IKategoriRepository _kategoriRepository;
        public KategoriServices(IKategoriRepository kategoriRepository)
        {
            _kategoriRepository = kategoriRepository;
        }

        public async Task<List<Kategori>> GetAllkategoris()
        {
            var kategori = await _kategoriRepository.GetAll();
            return kategori;
        }

        public async Task<Kategori> GetKategoriById(int id)
        {
            var kategori = await _kategoriRepository.GetById(id);
            return kategori;
        }
        public async Task<Kategori> Create(Kategori kategori)
        {
            var newKategori = await _kategoriRepository.Create(kategori);
            return newKategori;
        }

        public async Task<Kategori> Update(int id, Kategori kategori)
        {
            var editKategori = await _kategoriRepository.Update(id, kategori);
            return editKategori;
        }
        public async Task<Kategori> Delete(int id)
        {
            var kategori = await _kategoriRepository.Delete(id);
            return kategori;
        }
    }
}
