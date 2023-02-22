using BlogPost.Data.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;




var builder = WebApplication.CreateBuilder(args);


Log.Logger = new LoggerConfiguration()
               .WriteTo.File(
               path: "/Users/jpmac/Desktop/Logs/BLOGPOSTLAPILOGS-.txt",
               outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm,ss.fff zzz}[{Level:u3}] {Message:lj}{NewLine}{Exception}",
               rollingInterval: RollingInterval.Day,
               restrictedToMinimumLevel: LogEventLevel.Information
               ).CreateLogger();

builder.Host.UseSerilog();


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<BlogPostDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("BlogPostDbContext")));

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

