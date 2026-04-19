using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace minesweeper_server.Hubs;

[Authorize]
public class GameHub : Hub
{
    // TODO: Implement SignalR hub methods in Phase 7
}
