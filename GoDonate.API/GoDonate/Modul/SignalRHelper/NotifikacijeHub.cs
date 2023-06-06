﻿using Microsoft.AspNetCore.SignalR;

namespace GoDonate.Modul.SignalRHelper
{
    public class NotifikacijeHub : Hub
    {
        public async Task PosaljiPoruke (string poruka)
        {
            await Clients.All.SendAsync("PosaljiPoruke", poruka);
        }
    }
}
