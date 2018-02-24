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
    public class FakeCategoryRepository : ICategoryRepository
    {
        List<Category> CategoryRepo = new List<Category>() {
            new Category{ CategoryId=1, CategoryName="aaaaa" },
            new Category{ CategoryId=2, CategoryName="bbbbb" }
        };

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            if (filter == null)
                return CategoryRepo;
            return CategoryRepo.Where(filter.Compile()).ToList();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
