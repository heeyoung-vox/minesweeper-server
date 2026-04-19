# Minesweeper Server

A multiplayer Minesweeper backend built with .NET 8, PostgreSQL, Redis, and SignalR.

## Tech Stack
- **.NET 8** - Web API framework
- **PostgreSQL** - Primary database with EF Core
- **Redis** - Real-time game state storage
- **SignalR** - WebSocket communication
- **JWT Authentication** - User authentication

## Setup

### Database
1. Install PostgreSQL
2. Update `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Host=localhost;Database=minesweeper;Username=postgres;Password=your_password"
   }
   ```

### Redis
1. Install Redis
2. Update connection string in `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "Redis": "localhost:6379"
   }
   ```

### Run
```bash
dotnet ef database update  # Apply migrations
dotnet run           # Start server
```

