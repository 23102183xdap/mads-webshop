using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Database;
using MN_Groop_A.P.S.Domain;
using MN_Groop_A.P.S.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace MN_Groop_A.P.S.Repositories
{
    public class DeliveryRepository: IDeliveryRepository
    {
        private readonly MNGroupDBConktext _context;

        public DeliveryRepository (MNGroupDBConktext conktext)
        {
            _context = conktext;
        }
        public async Task<Delivery> Create(int Antal, string name, string address, int leveringspris, string leveringsmetode, Delivery delivery)
        {
            delivery.CreateAt = DateTime.Now;
            _context.Delivery.Add(delivery);
            await _context.SaveChangesAsync();
            return delivery;
            
        }
       
       
        public async Task<Delivery> Update(int id, Delivery Delivery)
        {
            var editDelivery = await _context.Delivery.FirstOrDefaultAsync(a => a.Id == id);
            if (editDelivery != null)
            {
                editDelivery.UpdatetAt = DateTime.Now;
                editDelivery.name = Delivery.name;
                editDelivery.Antal = Delivery.Antal;
                editDelivery.address = Delivery.address;
                editDelivery.leveringspris = Delivery.leveringspris;
                editDelivery.leveringsmetode = Delivery.leveringsmetode;
                _context.Delivery.Update(editDelivery);
                await _context.SaveChangesAsync();
            }
            return editDelivery;
        }
        public async Task<Delivery> Delete(int id)
        {
            var Delivery = await _context.Delivery.FirstOrDefaultAsync(a => a.Id == id);
            if (Delivery != null)
            {
                Delivery.DelitedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }
            return Delivery;
        }

       
    }
}

