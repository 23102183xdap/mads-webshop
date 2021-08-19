using MN_Groop_A.P.S.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.IServices
{
    public interface IOrder_Detailes_Services
    {
        Task<List<Order_detalise>> GetAllOrder_Detailes();
        Task<Order_detalise> GetOrder_DetailesById(int id);
        Task<Order_detalise> Create(Order_detalise order_Detalise);
        Task<Order_detalise> Update(int id, Order_detalise order_Detalise);
        Task<Order_detalise> Delete(int id);
    
    }
}
