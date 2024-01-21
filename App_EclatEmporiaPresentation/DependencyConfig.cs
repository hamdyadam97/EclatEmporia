using App.Application.Contracts;
using App.Application.Services;
using App.Context;
using App.Infrastructure.Repositories;
using Autofac;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_EclatEmporiaPresentation
{
	public static class DependencyConfig
	{
		public static IContainer Configure()
		{
			var builder = new ContainerBuilder();

			
			
			
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            // Add more repository registrations as needed

            // Register services
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();
            // Add more service registrations as needed

            // Register the database context
            builder.RegisterType<StoreContext>().As<StoreContext>();

            // Register a generic repository (if needed)
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            // Note: This is a generic registration and may not fit all scenarios.
            // Build and return the container
            return builder.Build();
		}
	}
}
