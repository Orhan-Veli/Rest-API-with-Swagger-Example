using DAL.Abstract;
using Entities;
using HotelBusiness.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelBusiness.Concrete
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;
        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }
        public async Task Create(Hotel hotel)
        {
           await _hotelRepository.Create(hotel);
        }

        public async Task Delete(int id)
        {
          await _hotelRepository.Delete(id);
        }

        public async Task<IEnumerable<Hotel>> GetHotels()
        {
          return await _hotelRepository.GetAll();
        }

        public async Task<Hotel> Update(Hotel hotel)
        {
            return await _hotelRepository.Update(hotel);
        }
    }
}
