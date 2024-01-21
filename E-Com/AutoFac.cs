using App.Application.Contracts;
using App.Application.Services;
using App.Context;
using App.Infrastructure.Repositories;
using App.Models.Models;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com
{
	public class AutoFac
	{
		//public static IContainer Inject()
		//{

		//	var builder = new ContainerBuilder();

		//	builder.RegisterType<ProductRepository>().As<IProductRepository>();
		//	builder.RegisterType<ProductService>().As<IProductService>();
		//	builder.RegisterType<StoreContext>().As<StoreContext>();
		//	builder.RegisterType<Repository<Product, int>>().As<IRepository<Product, int>>();

			
		//	return builder.Build();




		//}
	}
}
