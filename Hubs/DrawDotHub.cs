 
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class DrawDotHub : Hub
    {

        
        public async Task UpdateCanvas(int x, int y, string color)
        {
            await Clients.All.SendAsync("updateDot", x, y , color);
        }

        public async Task ClearCanvas()
        {
            await Clients.All.SendAsync("clearCanvas");
        }
    }

}