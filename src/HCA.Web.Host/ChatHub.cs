using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace HCA.Web.Host
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public override Task OnConnectedAsync()
        {
            //var LoggedInUser = _context.Users.FirstOrDefault(x => x.UserName == Context.User.Identity.Name);
            //LoggedInUser.isOnline = true;
            //_context.SaveChangesAsync();
            //Groups.AddToGroupAsync(Context.ConnectionId, LoggedInUser.Id);

            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            //var LoggedInUser = _context.Users.FirstOrDefault(x => x.UserName == Context.User.Identity.Name);
            //LoggedInUser.isOnline = false;
            //_context.SaveChangesAsync();
            //Groups.RemoveFromGroupAsync(Context.ConnectionId, LoggedInUser.Id);
            return base.OnDisconnectedAsync(exception);
        }
    }
}
