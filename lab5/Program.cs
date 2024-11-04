using Microsoft.EntityFrameworkCore;
using lab5.Data;
using System;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

//Configurar o DataDirectory para encontra a pasta Database 
// Configurar o DataDirectory para apontar para a pasta Database no projeto
var databasePath = Path.Combine(Directory.GetCurrentDirectory(), "Database");
AppDomain.CurrentDomain.SetData("DataDirectory", databasePath);

// Obter a string de conexão e configurar o DbContext para usar SQL Server
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DBCtrl>(options =>
    options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
