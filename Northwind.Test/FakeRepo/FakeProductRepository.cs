using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Test.FakeRepo
{
    public class FakeProductRepository : IProductRepository
    {
        List<Product> productRepo = new List<Product>() {
            new Product{ ProductId=1, CategoryId=1, ProductName="a", UnitPrice=10, UnitsInStock=100, QuantityPerUnit="10" },
            new Product{ ProductId=2, CategoryId=1, ProductName="b", UnitPrice=15, UnitsInStock=1000, QuantityPerUnit="100" }
        };

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            if (filter == null)
                return productRepo;
            return productRepo.Where(filter.Compile()).ToList();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
