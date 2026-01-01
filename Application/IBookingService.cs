using HotelBookingAPI.Entities;

namespace HotelBookingAPI.Application
{
    public interface IBookingService
    {
        Booking createBooking(Booking booking);
        List<Booking> getBookings();

    }
}
