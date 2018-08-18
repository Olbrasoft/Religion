using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Olbrasoft.Religion.UnitTest
{
    [TestFixture]
    public class GroupOfReligionLocalizedTest
    {
        [Test]
        public void IsInstanceOfILocalized()
        {
            //Arrange
            var type = typeof(ILocalized);

            //Act
            var groupOfReligionLocalized = new GroupOfReligionLocalized();

            //Assert
            Assert.IsInstanceOf(type, groupOfReligionLocalized);


        }
       
    }

    public class GroupOfReligionLocalized : ILocalized
    {

    }

    public interface ILocalized
    {

    }
}
