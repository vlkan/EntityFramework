﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product { ProductID=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15 },
            new Product { ProductID = 2, CategoryId = 2, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3 },
            new Product { ProductID = 3, CategoryId = 3, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 5 },
            new Product { ProductID = 4, CategoryId = 4, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 65 },
            new Product { ProductID = 5, CategoryId = 5, ProductName = "Fare", UnitPrice = 85, UnitsInStock = 1 },
            };   
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductID == product.ProductID);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
        }

        public List<Product> GetAllByCategory(int categoryId) {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
