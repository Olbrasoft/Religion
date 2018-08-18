using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Religion.Mvc.Models;

namespace Olbrasoft.Religion.Mvc.UnitTest
{
    [TestFixture()]
    public class ReligionDataTransferObjectTest
    {
        [Test]
        public void IsInstanceOfIReligionDataTransferObject()
        {
            var rdto = new ReligionDataTransferObject();

            Assert.IsInstanceOf<IReligionDataTransferObject>(rdto);

        }

        [Test]
        public void NameIsInstanceOfString()
        {
            IReligionDataTransferObject o = new ReligionDataTransferObject
            {
                Name = ""
            };

            var name = o.Name;

            Assert.IsInstanceOf<string>(name);
        }

    }
}
