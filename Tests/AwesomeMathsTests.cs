using NUnit.Framework;
using NUnitExplicitTest;

namespace Tests
{
    public class AwesomeMathsTests
    {
        [Test]
        public void AddWorks()
        {
            Assert.AreEqual(3, AwesomeMaths.Add(1, 2));
        }

        [Test, Explicit]
        public void DivideDoesntWork()
        {
            Assert.AreEqual(1337, AwesomeMaths.Divide(42, 0));
        }
    }
}
