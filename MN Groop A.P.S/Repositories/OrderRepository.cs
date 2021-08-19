using Microsoft.EntityFrameworkCore;
using MN_Groop_A.P.S.Database;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly MNGroupDBConktext _context;
        public OrderRepository(MNGroupDBConktext context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetAll()
        {
            return await _context.Order
                .Where(a => a.DelitedAt == null)
                .Include(a => a.OrderDate)
                .ToListAsync();
        }
        public async Task<Order> GetById(int id)
        {
            return await _context.Order
                .Where(a => a.DelitedAt == null)
                .Include(a => a.OrderDate)
                .FirstOrDefaultAsync();
        }
       
        public async Task<Order> Update(int id, Order order)
        {
            var editOrder = await _context.Order.FirstOrDefaultAsync(a => a.Id == id);
            if (editOrder != null)
            {
                editOrder.UpdatetAt = DateTime.Now;
                _context.Order.Update(editOrder);
                await _context.SaveChangesAsync();
            }
            return editOrder;

          
        }
        public async Task<Order> Create(Order order)
        {
            order.CreateAt = DateTime.Now;
            _context.Order.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }
        

        public async Task<Order> Delete(int id)
        {
            var order = await _context.Order.FirstOrDefaultAsync(a => a.Id == id);
            if (order != null)
            {
                order.DelitedAt = DateTime.Now;
                await _context.SaveChangesAsync();

            }
            return order;
        }

        public Task<Order> LoginId(int id)
        {
            throw new NotImplementedException();
        }

    }
}
