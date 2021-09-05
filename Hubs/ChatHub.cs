using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace signalRTeste.Hubs
{
    public class ChatHub : Hub
    {
        public async Task MessageSender(string user, string message)
        {
            await Clients.All.SendAsync("MessageReceiver", user,message);
        }
    }
}