using Microsoft.EntityFrameworkCore;
using React_API.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Configure the Sql Server Database ConnectionStrings
builder.Services.AddDbContext<React_APIContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("TEConnection")));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
