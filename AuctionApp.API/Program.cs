using AuctionApp.Core.Services;
using AuctionApp.Core.UnitOfWork;
using AuctionApp.Data.Data.Context;
using AuctionApp.Data.Repositories.Abstract;
using AuctionApp.Data.Repositories.Concrete;
using AuctionApp.Data.UnitOfWork;
using AuctionApp.Service.Services;
using AuctionApp.Service.Services.Abstract;
using AuctionApp.Service.Services.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<AuctionAppDbContext>(options =>  options.UseSqlServer(builder.Configuration.GetConnectionString("Db")));
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IGenericService<>,GenericService<>>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IVehicleRepository ,VehicleRepository>();
builder.Services.AddScoped<IVehicleService,VehicleService >();

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
