using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.IRepositories;
using MN_Groop_A.P.S.Repositories;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IServices;

namespace MN_Groop_A.P.S.services
{
    public class Order_deatails_Services : IOrder_Detailes_Services
    {
        private readonly IOrder_DetailseRepository _order_DetailseRepository;
        public Order_deatails_Services(IOrder_DetailseRepository order_DetailseRepository)
        {
            _order_DetailseRepository = order_DetailseRepository;
        }
        public async Task<List<Order_detalise>> GetAllOrder_Detailes()
        {
            var orderDeatailse = await _order_DetailseRepository.GetAll();
            return orderDeatailse;
        }

        public async Task<Order_detalise> GetOrder_DetailesById(int id)
        {
            var orderDeatailse = await _order_DetailseRepository.GetById(id);
            return orderDeatailse;
        }

        public async Task<Order_detalise> GetById(int id)
        {
            var orderDeatailse = await _order_DetailseRepository.GetById(id);
            return orderDeatailse;
        }

        public async Task<Order_detalise> Update(int id, Order_detalise order_Detalise)
        {
            var editOD = await _order_DetailseRepository.Update(id, order_Detalise);
            return editOD;
        }
        public async Task<Order_detalise> Create(Order_detalise order_Detalise)
        {
            var newOD = await _order_DetailseRepository.Create(order_Detalise);
            return newOD;
        }

        public async Task<Order_detalise> Delete(int id)
        {
            var OD = await _order_DetailseRepository.Delete(id);
            return OD;
        }

    }
}
