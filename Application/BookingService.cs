using HotelBookingAPI.Data;
using HotelBookingAPI.Entities;

namespace HotelBookingAPI.Application
{
    //logics
    public class BookingService :  IBookingService
    {
        private readonly AppDbContext _context;

        public BookingService(AppDbContext context)
        {
            _context = context;
        }

        public List<Booking> getBookings()
        {
            return _context.Bookings.ToList();
        }

        public Booking createBooking(Booking booking)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.id == booking.roomId);

            if (room == null || !room.isAvailable)
            {
                throw new Exception("Room is not available");
            }

            room.isAvailable = false;
            _context.Bookings.Add(booking);
            _context.SaveChanges();

            return booking;
        }
    }
}
