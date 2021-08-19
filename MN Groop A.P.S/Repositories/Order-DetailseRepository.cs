using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MN_Groop_A.P.S.Database;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IRepositories;

namespace MN_Groop_A.P.S.Repositories
{
    public class Order_DetailseRepository : IOrder_DetailseRepository
    {

        

        private readonly MNGroupDBConktext _context;
        public Order_DetailseRepository(MNGroupDBConktext conktext)

        {
            _context = conktext;
        }
       
        public async Task<List<Order_detalise>> GetAll()
        {
            return await _context.order_Detalise
                 .Where(a => a.DelitedAt == null)
                 .ToListAsync();
        }

        public async Task<Order_detalise> GetById(int id)
        {
            return await _context.order_Detalise
                .Where(a => a.DelitedAt == null)
                .FirstOrDefaultAsync(a => a.Id == id);

        }

        
        public async Task<Order_detalise> Create(Order_detalise order_Detalise)
        {
            order_Detalise.CreateAt = DateTime.Now;
            _context.order_Detalise.Add(order_Detalise);
            await _context.SaveChangesAsync();
            return order_Detalise;
        }
        public async Task<Order_detalise> Update(int id, Order_detalise order_Detalise)
        {
            var editOrderDeatlise = await _context.order_Detalise.FirstOrDefaultAsync(a => a.Id == id);
            if (editOrderDeatlise != null)
            {
                editOrderDeatlise.UpdatetAt = DateTime.Now;
                editOrderDeatlise.Antal = order_Detalise.Antal;
                editOrderDeatlise.StkPris = order_Detalise.StkPris;
                _context.order_Detalise.Update(order_Detalise);
                await _context.SaveChangesAsync();
            }
            return order_Detalise;
        }

        public Task<Order_detalise> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
