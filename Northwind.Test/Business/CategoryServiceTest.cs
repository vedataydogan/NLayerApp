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
    public class CategoryServiceTest : TestBase
    {       
        
        [TestMethod]
        public void ShouldGetAllCategories()
        {
            var result = CategoryService.GetAll();
            Assert.AreNotEqual(0, result.Count);
        }
    }
}
