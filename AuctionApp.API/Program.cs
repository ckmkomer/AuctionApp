using AuctionApp.API.Modules;
using AuctionApp.Core.Repositories;
using AuctionApp.Data.Context;
using AuctionApp.Data.Repositories;
using AuctionApp.Data.Repositories.Abstract;
using AuctionApp.Data.Repositories.Concrete;
using AuctionApp.Service.Mapping;
using AuctionApp.Service.Services.Abstract;
using AuctionApp.Service.Services.Concrete;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
var connectionString = builder.Configuration.GetConnectionString("DbCon");
builder.Services.AddDbContext<AuctionAppDbContext>(x => x.UseSqlServer(connectionString));
builder.Services.AddAutoMapper(typeof(MappingProfile));


builder.Services.AddScoped(typeof(NotFoundFilter<>));
builder.Services.AddSwaggerGen();

builder.Host.UseServiceProviderFactory
    (new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepoServiceModule()));



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
