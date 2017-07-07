using NUnit.Framework;
using System;

namespace tests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            Assert.Equals(1,2);
        }
    }
}
