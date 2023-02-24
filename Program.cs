using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GPOI_AppGrafi.Data;
using GPOI_AppGrafi.Models;
using System;
using GPOI_AppGrafi.Controllers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<GPOI_AppGrafiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GPOI_AppGrafiContext") ?? throw new InvalidOperationException("Connection string 'GPOI_AppGrafiContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var dbController = new Neo4jController();
Node node1 = new Node(10, "ciccio", null);
Node node2 = new Node(20, "pupa", node1);
await dbController.DeleteNode(node1);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
