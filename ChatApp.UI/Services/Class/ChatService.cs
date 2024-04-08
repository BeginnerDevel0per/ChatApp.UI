using ChatApp.UI.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace ChatApp.UI.Services.Class
{
    public class ChatService : IChatService
    {
        private readonly NavigationManager _navigationManager;         //bu nesneyi urlyi çekmek için kullanıyoruz
        public ChatService(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;

        }
        public HubConnection HubConnection { get; private set; }



        public async Task InitializeHubConnectionAsync(string accessToken)
        {
            HubConnection = new HubConnectionBuilder()
             .WithUrl("https://localhost:7255/Chathub", options =>
             {
                 options.AccessTokenProvider = () => Task.FromResult(accessToken);
             })
             .WithAutomaticReconnect().Build();
            var yakala = _navigationManager.BaseUri;
        }
        public async Task<bool> ConnectionState()
        {
            while (true)
            {
                if (HubConnection != null)
                {
                    return true;

                }
                await Task.Delay(200);
            }
        }
    }
}
