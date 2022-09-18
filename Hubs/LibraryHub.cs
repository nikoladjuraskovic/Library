using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace Library.Hubs
{
    [Authorize]
    public class LibraryHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
            //saljem poruku svim klijentima

            
        }
    }
}
