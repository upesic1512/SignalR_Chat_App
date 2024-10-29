using Microsoft.AspNetCore.SignalR;

namespace SignalR_Chat_App.ChatHub
{
    public class ChatHub: Hub
    {
        public async Task SendMessage(string user_name, string message, DateTime date)
            => await Clients.All.SendAsync("receive_message", user_name, message, date);

    }
}
