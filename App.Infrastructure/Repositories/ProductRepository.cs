﻿using App.Application.Contracts;
using App.Context;
using App.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Repositories
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
        StoreContext context;

        public ProductRepository(StoreContext dbContext) : base(dbContext) {
			context = dbContext;
		}

		public IQueryable<Product> GetProductByName(string name)
		{
			
            return context.Products.Where(x => x.ProductName.Contains(name)).AsQueryable();

        }

        //public IQueryable<Product> GetProductByName(string name)
        //{
        //          return context.Products.Where(x => x.ProductName.Contains(name)).AsQueryable();
        //      }
        public IQueryable<Product> GetProducts()
        {
            return context.Products.Select(x => x);
        }

    }
}
