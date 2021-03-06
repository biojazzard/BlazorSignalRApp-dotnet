// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorSignalRApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/tallerdelsoho/Projects/dotnet/BlazorSignalRApp/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/tallerdelsoho/Projects/dotnet/BlazorSignalRApp/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/tallerdelsoho/Projects/dotnet/BlazorSignalRApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/tallerdelsoho/Projects/dotnet/BlazorSignalRApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/tallerdelsoho/Projects/dotnet/BlazorSignalRApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/tallerdelsoho/Projects/dotnet/BlazorSignalRApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/tallerdelsoho/Projects/dotnet/BlazorSignalRApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/tallerdelsoho/Projects/dotnet/BlazorSignalRApp/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/tallerdelsoho/Projects/dotnet/BlazorSignalRApp/Client/_Imports.razor"
using BlazorSignalRApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/tallerdelsoho/Projects/dotnet/BlazorSignalRApp/Client/_Imports.razor"
using BlazorSignalRApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/tallerdelsoho/Projects/dotnet/BlazorSignalRApp/Client/Pages/Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "/Users/tallerdelsoho/Projects/dotnet/BlazorSignalRApp/Client/Pages/Index.razor"
       
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string userInput;
    private string messageInput;

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
            .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            var encodedMsg = $"{user}: {message}";
            messages.Add(encodedMsg);
            StateHasChanged();
        });

        await hubConnection.StartAsync();
    }

    Task Send() =>
        hubConnection.SendAsync("SendMessage", userInput, messageInput);

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        await hubConnection.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
