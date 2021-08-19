using MN_Groop_A.P.S.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.IServices
{
    public interface IOrderServices
    {
        Task<List<Order>> GetAllOrders();
        Task<Order> GetOrderById(int id);
        Task<Order> Create(Order order);
        Task<Order> Update(int id, Order order);
        Task<Order> Delete(int id);
        Task<Order> LoginId(int id);
    }
}
