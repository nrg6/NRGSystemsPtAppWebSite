using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Azure;
using MudBlazor.Services;
using NRGSystemsPtAppWebSite.Components;
using NRGSystemsPtAppWebSite.Components.Pages.MessagesReports;
using NRGSystemsPtAppWebSite.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// taken from Blazor Authentication Tutorial
// https://www.youtube.com/watch?v=GKvEuA80FAE
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Cookie.Name = "auth_token";
        options.LoginPath = "/login";
        options.Cookie.MaxAge = TimeSpan.FromMinutes(30);
        options.AccessDeniedPath = "/access-denied";
    });
builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();

builder.Services.AddSweetAlert2();

builder.Services.AddMudServices();

//builder.Services.AddScoped<AppStateService>();
builder.Services.AddScoped<AppDownloadService>();

builder.Services.AddSingleton<FunctionRestService>();
builder.Services.AddSingleton<ClientRestFunctionServices>();
builder.Services.AddSingleton<ExerciseRestFunction>();
builder.Services.AddSingleton<CalendarFunctionServices>();

builder.Services.AddSingleton<CommentsColumn>();
builder.Services.AddSingleton<ProgramExerciseList>();

builder.Services.AddAzureClients(azureBuilder =>
{
    azureBuilder.AddBlobServiceClient(builder.Configuration.GetConnectionString("AzureClientString"));
});

builder.Services.AddBlazorBootstrap();
//builder.Services.AddHttpClient("api", httpClient => httpClient.BaseAddress = new Uri("http://localhost:5186/"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

// taken from Blazor Authentication Tutorial
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
