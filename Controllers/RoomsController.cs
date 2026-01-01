using HotelBookingAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingAPI.Controllers
{

    [ApiController]
    [Route("api/rooms")]
    public class RoomsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RoomsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetRooms()
        {
            return Ok(_context.Rooms.ToList());
        }
    }
}
