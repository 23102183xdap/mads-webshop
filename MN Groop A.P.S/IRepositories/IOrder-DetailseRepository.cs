using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Domain;

namespace MN_Groop_A.P.S.IRepositories
{
    public interface IOrder_DetailseRepository
    {
        Task<List<Order_detalise>> GetAll();
        Task<Order_detalise> GetById(int id);
        Task<Order_detalise> Create(Order_detalise order_Detalise);
        Task<Order_detalise> Update(int id, Order_detalise order_Detalise);
        Task<Order_detalise> Delete(int id);
    }
}
