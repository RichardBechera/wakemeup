using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Wakemeup.Hubs
{
    public class AwakingHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}