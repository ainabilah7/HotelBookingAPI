# Hotel Booking API
A simple Hotel Room Booking API.

This API allows users to:
- List all available rooms
- Book a room for a guest
- Get all bookings

## Tech Stack
- C# (.NET 8)
- ASP.NET Core Web API
- Entity Framework Core (InMemory database)
- Swagger for API documentation

## How to Run
1. Clone the repository: git clone https://github.com/ainabilah7/HotelBookingAPI.git
2. Navigate to the project folder: cd HotelBookingAPI
3. Restore dependencies: dotnet restore
4. Build the project: dotnet build
5. Run the application : dotnet run
6. Open Swagger in browser for testing: http://localhost:5118/swagger

## API endpoints
- GET /api/bookings
- POST /api/bookings
- GET /api/rooms

### Example:
```json
{
	"guestName": "John Doe",
	"roomId": 1,
	"checkInDate": "2025-05-01",
	"checkOutDate": "2025-05-03"
}
```

## Design Decisions
- Used **In-Memory database** as recommended
- Followed **Clean Architecture principles**:
	- Controllers = handle HTTP request
	- Application = logics
	- Data = database
- Used **Dependency Injection** for BookingService.
