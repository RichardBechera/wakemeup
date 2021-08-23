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
        
        public async Task SendPlaySound(string sound)
        {
            await Clients.All.SendAsync("PlaySound", sound);
        }
        
        public async Task SendPauseSound()
        {
            await Clients.All.SendAsync("PauseSound");
        }
    }
}