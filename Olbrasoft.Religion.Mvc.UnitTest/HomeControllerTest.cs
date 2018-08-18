using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Moq;
using NUnit.Framework;
using Olbrasoft.Religion.Mvc.Controllers;
using Olbrasoft.Religion.Mvc.Models;

namespace Olbrasoft.Religion.Mvc.UnitTest
{
    [TestFixture]
    public class HomeControllerTest
    {
        
        [Test]
        public void HomeControllerIsInstanceOfRelligionController()
        {
            
            //Act
            var hc= HomeController;

            //Assert 
            Assert.IsInstanceOf<ReligionController>(hc);

        }

        [Test]
        public void IndexReturnResultIsInstanceOfIReligionActionResult()
        {
            //Arrange
            var hc = HomeController;

            //Act
            var r = hc.Index();

            //Assert
            Assert.IsInstanceOf<ActionResult>(r);
        }


        [Test]
        public void IndexViewResulViewDataModelIsInstanceOfIEnumerableOfReligionDataTransferObject()
        {
            //Arrange
            var hc = HomeController;
            var viewResult = hc.Index() as ViewResult;

            //Act
            var religions = viewResult.Model;

            //Assert
            Assert.IsInstanceOf<IEnumerable<ReligionDataTransferObject>>(religions);

        }


        [Test]
        public void IndexResturnsMoreZeroItems()
        {
            var hc = HomeController;
            var r = hc.Index() as ViewResult;

            var religions = r.Model as IEnumerable<ReligionDataTransferObject>;

            Assert.IsTrue(religions.Any());

        }

        [Test]
        public void IndexReturnsMoreOneItems()
        {
            var hc = HomeController;


        }


        private static IReligionsFacade ReligionsFacade
        {
            get
            {
                var mFacade = new Mock<IReligionsFacade>();

                IReligionsFacade facade = mFacade.Object;
                return facade;
            }
        }


        private static HomeController HomeController { get; } = new HomeController(ReligionsFacade);
    }
}
