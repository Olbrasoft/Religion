using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Olbrasoft.Religion.UnitTest
{
    [TestFixture]
    public class GroupOfReligionTest
    {

        [Test]
        public void IsInstanceOfIGroupOfReligion()
        {
            var type = typeof(IGroupOfReligion);

            var groupOfReligion = new GroupOfReligion();

            Assert.IsInstanceOf(type, groupOfReligion);
        }

        [Test()]
        public void IdIsInstanceOfInteger()
        {
            IGroupOfReligion gr = new GroupOfReligion();

            var id = gr.Id;

            Assert.IsInstanceOf<int>(id);

        }


       
       
    }

    public class GroupOfReligion : IGroupOfReligion
    {
        public int Id { get; set; }
    }

    public interface IGroupOfReligion
    {
        int Id { get; set; }
    }
}
