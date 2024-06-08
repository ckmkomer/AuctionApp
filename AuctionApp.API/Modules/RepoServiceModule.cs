using AuctionApp.Core.Repositories;
using AuctionApp.Core.Services;
using AuctionApp.Core.UnitOfWork;
using AuctionApp.Data.Context;
using AuctionApp.Data.Repositories;
using AuctionApp.Data.Repositories.Abstract;
using AuctionApp.Data.Repositories.Concrete;
using AuctionApp.Data.UnitOfWork;
using AuctionApp.Service.Mapping;
using AuctionApp.Service.Services;
using AuctionApp.Service.Services.Abstract;
using AuctionApp.Service.Services.Concrete;
using Autofac;
using System.Reflection;

namespace AuctionApp.API.Modules
{
	public class RepoServiceModule : Autofac.Module
    {
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
			builder.RegisterGeneric(typeof(GenericService<,>)).As(typeof(IGenericService<,>)).InstancePerLifetimeScope();
			builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

			var apiAssembly = Assembly.GetExecutingAssembly();
			var dataAssembly = Assembly.GetAssembly(typeof(AuctionAppDbContext));
			var serviceAssembly = Assembly.GetAssembly(typeof(MappingProfile));

			builder.RegisterAssemblyTypes(apiAssembly, dataAssembly, serviceAssembly)
				   .Where(x => x.Name.EndsWith("Repository"))
				   .AsImplementedInterfaces()
				   .InstancePerLifetimeScope();

			builder.RegisterAssemblyTypes(apiAssembly, dataAssembly, serviceAssembly)
				   .Where(x => x.Name.EndsWith("Service"))
				   .AsImplementedInterfaces()
				   .InstancePerLifetimeScope();

			// VehicleRepository ve VehicleService sınıflarını ekleyin
			builder.RegisterType<VehicleRepository>().As<IVehicleRepository>().InstancePerLifetimeScope();
			builder.RegisterType<VehicleService>().As<IVehicleService>().InstancePerLifetimeScope();
		}

	}
}
