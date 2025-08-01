using Microsoft.EntityFrameworkCore;
using ProjectLogin.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LoginDbContext>(options =>
{
    var sqlConn = Environment.GetEnvironmentVariable("SQL_CONNECTION");
    options.UseSqlServer(sqlConn);
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
