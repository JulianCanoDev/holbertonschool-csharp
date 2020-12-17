using NUnit.Framework;
using MyMath;

namespace MyMath.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_Add_20_from_12_8()
        {
            Assert.AreEqual(20, Operations.Add(12, 8));
        }
    }
}