using HotelBookingAPI.Data;
using HotelBookingAPI.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Register AppDbContext with in-memory database
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseInMemoryDatabase("HotelData");
});

var app = builder.Build();

//create rooms data
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    db.Rooms.AddRange(
        new Room { id = 1, name = "101", type = "Single", isAvailable = true },
        new Room { id = 2, name = "102", type = "Double", isAvailable = true },
        new Room { id = 3, name = "201", type = "Suite", isAvailable = true }
        );

    db.SaveChanges();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
