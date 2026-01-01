namespace HotelBookingAPI.Entities
{
    public class Room
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public bool isAvailable { get; set; }
    }
}
