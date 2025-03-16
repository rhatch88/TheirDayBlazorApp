using Microsoft.EntityFrameworkCore;
using System;
using TheirDayBlazorApp.Components;
using TheirDayBlazorApp.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(); // Ensures it's running as a server app

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.WebHost.UseWebRoot("wwwroot");

var app = builder.Build();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode(); // Forces server-side Blazor

app.Run();
