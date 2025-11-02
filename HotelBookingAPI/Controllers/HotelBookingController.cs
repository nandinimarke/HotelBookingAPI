using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HotelBookingAPI.Models;
using HotelBookingAPI.Data;

namespace HotelBookingAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HotelBookingController : ControllerBase
    {
        private readonly ApiContext _context;
        public HotelBookingController(ApiContext context)
        {
            _context = context;
        }

        // setting up endpoint

        // create/edit
        [HttpPost]
        public JsonResult CreateEdit(HotelBooking booking)
        {
            if(booking.ID == 0)
            {
                _context.Bookings.Add(booking);
            }
            else
            {
                var bookingInDb = _context.Bookings.Find(booking.ID);

                if (bookingInDb == null)
                {
                    return new JsonResult(NotFound());
                }

                bookingInDb.RoomNo = booking.RoomNo;
                bookingInDb.ClientName = booking.ClientName;
                
            }
            _context.SaveChanges();
            return new JsonResult(Ok(booking));
        }

        //get
        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.Bookings.Find(id);

            if(result == null)
            {
                return new JsonResult(NotFound());
            }
            
            return new JsonResult(Ok(result));
            
        }

        // delete
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var reult = _context.Bookings.Find(id);

            if(reult == null)
            {
                return new JsonResult(NotFound());
            }
            
            _context.Bookings.Remove(reult);
            _context.SaveChanges();

            return new JsonResult(NoContent());
        }

        // get all
        [HttpGet]
        public JsonResult GetAll()
        {
            var result = _context.Bookings.ToList();
            return new JsonResult(Ok(result));
        }



    }
}
