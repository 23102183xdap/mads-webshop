using MN_Groop_A.P.S.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.IRepositories
{
    public interface IDeliveryRepository
    {

        Task<Delivery> Create(int Antal, string name, string address, int leveringspris, string leveringsmetode, Delivery delivery);
        Task<Delivery> Update(int id, Delivery delivery);
        Task<Delivery> Delete(int id);
    }
}
