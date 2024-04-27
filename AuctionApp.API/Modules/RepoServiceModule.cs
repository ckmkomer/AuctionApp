using AuctionApp.Core.Repositories;
using AuctionApp.Core.Services;
using AuctionApp.Core.UnitOfWork;
using AuctionApp.Data.Data.Context;
using AuctionApp.Data.Repositories;
using AuctionApp.Data.UnitOfWork;
using AuctionApp.Service.Mapping;
using AuctionApp.Service.Services;
using Autofac;
using System.Reflection;
using Module = Autofac.Module;
namespace AuctionApp.API.Modules

{
	public class RepoServiceModule :Module
	{
		protected override void Load(Autofac.ContainerBuilder builder)
		{
			builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();

		

			builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();


			var apiAssembly = Assembly.GetExecutingAssembly();
			var dataAssembly = Assembly.GetAssembly(typeof(AuctionAppDbContext));
			var serviceAssembly = Assembly.GetAssembly(typeof(MappingProfile));


			builder.RegisterAssemblyTypes(apiAssembly, dataAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

			builder.RegisterAssemblyTypes(apiAssembly, dataAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

			


		
	}
	}
}
