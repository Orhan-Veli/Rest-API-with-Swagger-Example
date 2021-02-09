using DAL.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public async Task Create(Hotel hotel)
        {
            using (HotelContext db = new HotelContext())
            {
                db.Hotels.Add(hotel);
                await db.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            using (HotelContext db = new HotelContext())
            {
                var entity = db.Hotels.FirstOrDefault(x => x.Id == id);
                db.Hotels.Remove(entity);
                await db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Hotel>> GetAll()
        {
            using (HotelContext db = new HotelContext())
            {
                return await db.Hotels.ToListAsync();
            }
        }

        public async Task<Hotel> Update(Hotel hotel)
        {
            using (HotelContext db = new HotelContext())
            {
                var entity =await db.Hotels.FirstOrDefaultAsync(x=> x.Id==hotel.Id);
                entity.Name = hotel.Name;
                entity.LastName = hotel.LastName;
                entity.City = hotel.City;
                db.Update(entity);
               await db.SaveChangesAsync();
                return (entity);
            }
        }
    }
}
