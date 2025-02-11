using Microsoft.EntityFrameworkCore;
using DotNet9BlazorBookCatalog.Application.Interfaces;
using DotNet9BlazorBookCatalog.Components;
using DotNet9BlazorBookCatalog.Infrastructure.Context;
using DotNet9BlazorBookCatalog.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//builder.Services.AddDbContextFactory<BookCatalogDbContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("BookCatalogConnection"));
//});

// Use Sqlite
builder.Services.AddDbContextFactory<BookCatalogDbContext>
    (options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IBookRepository, BookRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
