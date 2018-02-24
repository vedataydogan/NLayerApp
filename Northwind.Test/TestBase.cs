using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.Test.FakeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Test
{
    public class TestBase
    {
       public ICategoryService CategoryService {
            get {
                var _categoryRepository = new FakeCategoryRepository();
                return new CategoryManager(_categoryRepository);
            }
       }
     
        public IProductService ProductService {
            get {
                var _productRepository = new FakeProductRepository();
                return new ProductManager(_productRepository);
            }
        }


    }
}
