using Blazored.LocalStorage;
using ChatApp.UI;
using ChatApp.UI.Services.Class;
using ChatApp.UI.Services.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7255") });
builder.Services.AddScoped<IChatService, ChatService>();
builder.Services.AddScoped<ILastMessagesService, LastMessagesService>();
builder.Services.AddBlazoredLocalStorage();
await builder.Build().RunAsync();
