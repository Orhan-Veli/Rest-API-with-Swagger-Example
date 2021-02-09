using Entities;
using HotelBusiness.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private IHotelService _hotelService;
        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<Hotel>>> GetAllHotels()
        {
            var entity=await _hotelService.GetHotels();
            return Ok(entity);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteHotel(int id)
        {
            await _hotelService.Delete(id);
            return Ok();
        }
        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<Hotel>> UpdateHotel([FromBody]Hotel hotel)
        {
            await _hotelService.Update(hotel);
            return Ok();
        }
        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult> CreateHotel([FromBody]Hotel hotel)
        {
            await _hotelService.Create(hotel);
            return Ok();
        } 
    }
}
