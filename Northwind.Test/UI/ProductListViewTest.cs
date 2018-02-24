using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.WebFormsUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Test.UI
{
    [TestClass]
    public class ProductListViewTest : TestBase
    {
        [TestMethod]
        public void ShoulListAllProducts()
        {
            var productListForm = new Form1(ProductService, CategoryService);
            productListForm.LoadFormData();            
        }
    }
}
