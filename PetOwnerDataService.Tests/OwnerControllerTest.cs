using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using PetOwnerDataService.Controllers;
using Moq;
using System.Net.Http;
using System.Web.Http;
using System.Collections.Generic;
using System.Web.Http.Hosting;
using PetOwnerDataService.Service;
using PetOwnerDataService.Model;

namespace CodeTestAPI.Tests
{
    [TestClass]
    public class OwnerControllerTest
    {

        [TestMethod]
        public void OwnerControllerTest_GetAllOwnerPetList_OK()
        {
            var mockOwnerPetService = new Mock<IOwnerPetService>();
            List<OwnerPet> ownerPetList=new List<OwnerPet>();
            mockOwnerPetService.Setup(x => x.GetAllOwnerPetList()).ReturnsAsync(ownerPetList);

            
            var controller = new OwnerController(mockOwnerPetService.Object)
            {
            };

            // Act
            var response = controller.GetAllOwnerPetList();

            // Assert
            Assert.IsInstanceOfType(response, typeof(Task<PetOwnerDTO.OwnerPetList>), "Correct Model");
        }

    }
}
