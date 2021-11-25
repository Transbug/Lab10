using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub {
        // sendmess cal from service
        public async Task SendMessage(string user, string message) {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
           //  recmess functioon call from browser
        }
    }
}