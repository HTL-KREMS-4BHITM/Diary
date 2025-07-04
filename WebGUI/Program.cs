using Domain.Repositories.Implementations;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Configurations;
using Model.Entities;
using WebGUI.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<DiaryContext>(
    options => options.UseMySql(
        builder.Configuration
            .GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 27))
    ), ServiceLifetime.Transient
);

builder.Services.AddTransient<IRepositoryAsync<Entry>, EntryRepository>();
builder.Services.AddTransient<IRepositoryAsync<NormalContent>, NormalContentRepository>();
builder.Services.AddTransient<IRepositoryAsync<ToDoListItem>, ToDoListRepository>();
builder.Services.AddTransient<IRepositoryAsync<Response>, ResponseRepository>();
builder.Services.AddTransient<IUserRepositoryAsync<User>, UserRepository>();
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

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();