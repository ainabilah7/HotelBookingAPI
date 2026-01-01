using HotelBookingAPI.Data;
using HotelBookingAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingAPI.Controllers
{
    [ApiController]
    [Route("api/bookings")]

    public class BookingsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BookingsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetBookings()
        {
            return Ok(_context.Bookings.ToList());
        }

        [HttpPost]
        public IActionResult CreateBooking(Booking booking)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.id == booking.roomId);

            if (room == null || !room.isAvailable)
            {
                return BadRequest("Room is not available.");
            }

            room.isAvailable = false;
            _context.Bookings.Add(booking);
            _context.SaveChanges();

            return Ok(booking);
        }
    }
}
