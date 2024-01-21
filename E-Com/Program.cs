using App.Application.Contracts;
using App.Application.Services;
using App.Context;
using App.Infrastructure.Repositories;
using App.Models.Models;
using Autofac;

namespace E_Com
{
	internal class Program
	{
		static IProductService productService;
		static void Main(string[] args)
		{

			var builder = new ContainerBuilder();

			//var container = AutoFac.Inject();
			//productService = container.Resolve<IProductService>();

			//productService = new ProductService(new ProductRepository(new StoreContext()));
	
			// Register your services and their dependencies
			//builder.RegisterType<ProductRepository>().As<IProductRepository>();
			//builder.RegisterType<ProductService>().As<IProductService>();
			//builder.RegisterType<StoreContext>().As<StoreContext>();
			//builder.RegisterType<Repository<Product, int>>().As<IRepository<Product, int>>();

			//var Container = builder.Build();

			//using (var scope = Container.BeginLifetimeScope())
			//productService = scope.Resolve<ProductService>();
			//productService = new ProductService(new ProductRepository(new StoreContext()));
			//Product product = new Product() { ProductName = "a", Price = 55 };


			//List<Product> products = productService.GetAllPagination(0, 3);
			//foreach (var item in products)
			//{
			//	Console.WriteLine(item.ProductName);
			//}




		}
	}
}
