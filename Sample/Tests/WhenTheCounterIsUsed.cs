using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sample.Tests
{
    [TestFixture]
    public class WhenTheCounterIsUsed
    {

        [SetUp]
        public void Setup()
        {
            ObjectCounter.ClearCounter();
        }

        [Test]
        public void ItShouldProperlyCountFor2ObjectsCreated()
        {
            var obj1 = new SampleObject1();
            var obj2 = new SampleObject1();

            Assert.AreEqual(2, ObjectCounter.Counter["SampleObject1"]);
        }

        [Test]
        public void ItShouldProperlyCountFor2DifferentObjectsCreated()
        {
            var obj1 = new SampleObject1();
            var obj2 = new SampleObject2();

            Assert.AreEqual(1, ObjectCounter.Counter["SampleObject1"]);
            Assert.AreEqual(1, ObjectCounter.Counter["SampleObject2"]);
        }

        [Test]
        public void ItShouldDecreaseCounterWhenAnObjectIsDisposed()
        {
            var obj1 = new SampleObject1();
            var obj2 = new SampleObject2();
            var obj3 = new SampleObject1();

            obj3.Dispose();

            Assert.AreEqual(1, ObjectCounter.Counter["SampleObject1"]);
            Assert.AreEqual(1, ObjectCounter.Counter["SampleObject2"]);
        }
    }
}
