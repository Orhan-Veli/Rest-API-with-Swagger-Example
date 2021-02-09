using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelBusiness.Abstract
{
    public interface IHotelService
    {
        Task Create(Hotel hotel);

        Task Delete(int id);

        Task<Hotel> Update(Hotel hotel);

        Task<IEnumerable<Hotel>> GetHotels();
    }
}
