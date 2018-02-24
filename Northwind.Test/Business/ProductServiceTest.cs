using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.Test.FakeRepo;

namespace Northwind.Test.Business
{    
    [TestClass]
    public class ProductServiceTest : TestBase
    {        
        [TestMethod]
        public void ShouldGetAllProducts()
        {
            var result = ProductService.GetAll();
            Assert.AreNotEqual(0, result.Count);
        }
    }
}
