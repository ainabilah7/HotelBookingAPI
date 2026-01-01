namespace HotelBookingAPI.Data
{
    using HotelBookingAPI.Entities;
    using Microsoft.EntityFrameworkCore;
    public class AppDbContext : DbContext
    {
        public  AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Room> Rooms => Set<Room>();
        public DbSet<Booking> Bookings => Set<Booking>();
    }
}
