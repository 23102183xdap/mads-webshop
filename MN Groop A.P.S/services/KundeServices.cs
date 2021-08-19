using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IRepositories;
using MN_Groop_A.P.S.IServices;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MN_Groop_A.P.S.services
{
    public class KundeServices : IKundeServices
    {
        private readonly IKundeRepository _kundeRepository;
        public KundeServices(IKundeRepository kundeRepository)
        {
            _kundeRepository = kundeRepository;
        }
        public async Task<List<Kunde>> GetAllKundes()
        {
            var kunde = await _kundeRepository.GetAll();
            return kunde;
        }

        public async Task<Kunde> GetKundeById(int id)
        {
            var kunde = await _kundeRepository.GetById(id);
            return kunde;
        }
        public async Task<Kunde> Create(Kunde kunde)
        {
            var newKunde = await _kundeRepository.Create(kunde);
            return newKunde;
        }
        public async Task<Kunde> Update(int id, Kunde kunde)
        {
            var editKunde = await _kundeRepository.Update(id, kunde);
            return editKunde;

        }
        public async Task<Kunde> Delete(int id)
        {
            var kunde = await _kundeRepository.Delete(id);
            return kunde;
        }


    }
}
