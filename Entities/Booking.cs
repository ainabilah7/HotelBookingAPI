namespace HotelBookingAPI.Entities
{
    public class Booking
    {
        public int id { get; set; }
        public string guestName { get; set; }
        public int roomId { get; set; }
        public DateTime checkInDate { get; set; }
        public DateTime checkOutDate { get; set; }
    }
}
