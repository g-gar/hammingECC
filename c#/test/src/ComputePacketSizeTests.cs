using hamming.command;
using NUnit.Framework;

namespace test{
    public class ComputeParityBitSizeTests{
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int[] data = new int[] {1};
            Assert.AreEqual(2, ComputeParityBitSize.execute(data));
        }
        
        [Test]
        public void Test4a()
        {
            int[] data = new int[] {1, 1};
            Assert.AreEqual(3, ComputeParityBitSize.execute(data));
        }
        
        [Test]
        public void Test4b()
        {
            int[] data = new int[] {1, 1, 1};
            Assert.AreEqual(3, ComputeParityBitSize.execute(data));
        }
        
        [Test]
        public void Test4c()
        {
            int[] data = new int[] {1, 1, 1, 1};
            Assert.AreEqual(3, ComputeParityBitSize.execute(data));
        }
        
        [Test]
        public void Test5()
        {
            int[] data = new int[] {1, 1, 1, 1, 1};
            Assert.AreEqual(4, ComputeParityBitSize.execute(data));
        }
    }
}