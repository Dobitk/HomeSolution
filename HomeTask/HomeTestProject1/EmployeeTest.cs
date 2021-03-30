using System.Threading.Tasks;
using HomeProject.Controllers;
using HomeProject.Domain;
using HomeProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Xunit;
using Assert = NUnit.Framework.Assert;


namespace HomeTestProject1
{

    [TestFixture]
    public class EmployeeControllerTest
        {
            
            private AllManager _manager;


             public EmployeeControllerTest(AllManager manager)
            {
                _manager = manager;
            }


        [Test]
        [DataTestMethod]
        
        public async Task TestIndexView()
            {


                var controller = new EmployeeController(_manager);
                var result = await controller.Index() as ViewResult;

                Assert.AreEqual("Index", result.ViewName);
            }

            [Test]
            [HttpGet]
        public async Task TestDetalisView()
            {


                var controller = new EmployeeController(_manager);
                var result = await controller.DetalisEmployee(1) as ViewResult;
                Assert.AreEqual("DetalisEmployee", result?.ViewName);
            }

            [Test]
           
            public async Task TestDeleteView()
            {


                var controller = new EmployeeController(_manager);
                var result = await controller.DeleteEmployee(1) as ViewResult;
                Assert.AreEqual("DeleteEmployee", result?.ViewName);
            }


        }
    
}