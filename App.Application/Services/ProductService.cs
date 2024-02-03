using App.Application.Contracts;
using App.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
	public class ProductService : IProductService
	{
		private readonly IProductRepository _productRepository;

		public ProductService(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		public void AddProduct(Product product)
		{
			_productRepository.Add(product);
		}

		public void DeleteProduct(int id)
		{
		  _productRepository.Delete(id);
		}

		public IEnumerable<Product> GetAllProducts()
		{
		   return  _productRepository.GetAll();
		}

		public Product GetProductById(int id)
		{
			return _productRepository.GetById(id);
		}

		public void UpdateProduct(Product product)
		{
			_productRepository.Update(product);
		}
        public IQueryable<Product> GetProducts(int num, int product)
        {
            return _productRepository.GetProducts().Skip(num * product).Take(product) ;
        }
        public IQueryable<Product> SearchProductsByName(string productName)
        {
            return _productRepository.SearchByName(productName);
        }

        public IQueryable<Product> GetAllProductsWithIncludes()
        {
            return _productRepository.GetAllProductsWithIncludes();
        }

        public void updateQuantityProduct(int Productid)
        {
            _productRepository.updateQuantityProduct(Productid);
        }
		
        
    }

		
	}


