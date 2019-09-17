using NUnit.Framework;
using System;

namespace Tests
{
    public class NUnitTests
    {
        [Test]
        public void TestThatWorks()
        { }

        [Test, Ignore("Does not work")]
        public void IgnoredTestDoesntWork()
        {
            throw new Exception();
        }

        [Test, Explicit]
        public void ExplicitTestDoesntWork()
        {
            throw new Exception();
        }
    }
}
