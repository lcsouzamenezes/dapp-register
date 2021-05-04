// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace register_web3_blazorwasm.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ETH\dapp-register\register-web3-blazorwasm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ETH\dapp-register\register-web3-blazorwasm\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ETH\dapp-register\register-web3-blazorwasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ETH\dapp-register\register-web3-blazorwasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ETH\dapp-register\register-web3-blazorwasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ETH\dapp-register\register-web3-blazorwasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ETH\dapp-register\register-web3-blazorwasm\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ETH\dapp-register\register-web3-blazorwasm\_Imports.razor"
using register_web3_blazorwasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ETH\dapp-register\register-web3-blazorwasm\_Imports.razor"
using register_web3_blazorwasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ETH\dapp-register\register-web3-blazorwasm\_Imports.razor"
using register_web3_blazorwasm.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\ETH\dapp-register\register-web3-blazorwasm\Components\RegisterWeb3.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class RegisterWeb3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\ETH\dapp-register\register-web3-blazorwasm\Components\RegisterWeb3.razor"
       
    [Inject] IJSRuntime JSRuntime { get; set; }
    private Task<IJSObjectReference> _module;
    private Task<IJSObjectReference> Module => _module ??= JSRuntime.InvokeAsync<IJSObjectReference>("import", "./js/RegisterWeb3.js").AsTask();
    private string value = ""; 
    private string result = "";
    private bool isLoading = false;
    private object dotNetReference;

    protected override void OnInitialized()
    {
        dotNetReference = DotNetObjectReference.Create(this);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            var module = await Module;
            await module.InvokeVoidAsync("Init");
        }
    }

    public async void RegisterSetInfo()
    {
        isLoading = true;
        StateHasChanged();
        
        var module = await Module;
        await module.InvokeVoidAsync("RegisterSetInfo", value, dotNetReference);
    }

    [JSInvokable("RegisterSetInfoCallback")]
    public void RegisterSetInfoCallback(bool isSuccess) 
    {
        if (isSuccess) {
            value = "";
        }

        isLoading = false;
        StateHasChanged();
    }

    public async void RegisterGetInfo()
    {
        var module = await Module;
        await module.InvokeVoidAsync("RegisterGetInfo", dotNetReference);
    }

    [JSInvokable("RegisterGetInfoCallback")]
    public void RegisterGetInfoCallback(string info) 
    {
        result = info;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
