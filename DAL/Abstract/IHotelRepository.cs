using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IHotelRepository
    {
        Task Create(Hotel hotel);

        Task Delete(int id);
        Task<Hotel> Update(Hotel hotel);

        Task<IEnumerable<Hotel>> GetAll();
    }
}
