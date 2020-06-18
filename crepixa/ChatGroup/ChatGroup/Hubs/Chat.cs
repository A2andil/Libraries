using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatGroup.Hubs
{
    public class Chat : Hub
    {
        public async Task Send(string nick, string message)
        {
            await Clients.All.SendAsync("Recieve", nick, message);
        }
    }
}
