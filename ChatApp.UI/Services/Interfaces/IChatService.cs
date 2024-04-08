using Microsoft.AspNetCore.SignalR.Client;

namespace ChatApp.UI.Services.Interfaces
{
    public interface IChatService
    {
        HubConnection HubConnection { get; }
        Task InitializeHubConnectionAsync(string accessToken);

        Task<bool> ConnectionState();
    }
}
