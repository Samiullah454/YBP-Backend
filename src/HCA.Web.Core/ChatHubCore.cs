using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace HCA
{
    public class ChatHubCore: Hub
    {
        private static Dictionary<string, string> userConnections = new Dictionary<string, string>();
        //public async Task SendMessage(string user, string message)
        //{
        //    await Clients.All.SendAsync("ReceiveMessage", user, message);
        //}
        public override async Task OnConnectedAsync()
        {
            
            var userId = Context.GetHttpContext().Request.Query["userId"];
            userConnections[userId] = Context.ConnectionId;
            await base.OnConnectedAsync();
            
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            //var LoggedInUser = _context.Users.FirstOrDefault(x => x.UserName == Context.User.Identity.Name);
            //LoggedInUser.isOnline = false;
            //_context.SaveChangesAsync();
            //Groups.RemoveFromGroupAsync(Context.ConnectionId, LoggedInUser.Id);
            return base.OnDisconnectedAsync(exception);
        }
        public string GetConnectionIdByUserId(string userId)
        {
            if (userConnections.TryGetValue(userId, out var connectionId))
            {
                return connectionId;
            }
            return null; // User ID not found
        }
        public async Task SendMessageToUser(string userId, string message)
        {
            var connectionId = GetConnectionIdByUserId(userId);

            if (connectionId != null)
            {
                // Send the message to the user's connection
                await Clients.Client(connectionId).SendAsync("ReceiveMessage", message);
            }
            else
            {
                // Handle the case where the user ID is not found
                // (e.g., user not connected)
                // You can log or handle it as needed
            }
        }
    }
}
