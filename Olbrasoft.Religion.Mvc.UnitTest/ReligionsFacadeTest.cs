
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
    [TestFixture]
    public class ReligionsFacadeTest
    {
        [Test]
        public void IsInstanceOfIReligionsFacade()
        {
            var religionsFacade = new ReligionsFacade();

            Assert.IsInstanceOf<IReligionsFacade>(religionsFacade);
        }

        
        [Test]
        public void GetIsInstanceOfIEnumerableOfReligionDataTransferObject()
        {
            IReligionsFacade facade = ReligionsFacade;

            var religions = facade.Get();

            Assert.IsInstanceOf<IEnumerable< ReligionDataTransferObject>>(religions);
        }

        [Test]
        public void GetMoreZeroItems()
        {
            var f = ReligionsFacade;

            var religions = f.Get();

            Assert.IsTrue(religions.Any());
        }

        private static ReligionsFacade ReligionsFacade
        {
            get { return new ReligionsFacade(); }
        }
    }
}
