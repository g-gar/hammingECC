using System.Linq;
using hamming.command;
using NUnit.Framework;

namespace test{
    public class IntegrationTests {
        
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void test1()
        {
            int[] data = new int[] {1, 0, 1, 0};
            int parityBitsSize = ComputeParityBitSize.execute(data);
            int[,] generator = CreateGeneratorMatrix.execute(parityBitsSize, data.Length);
            int[,] actual = MultiplyMatrices.execute(ReshapeMatrix.execute(data, 1, data.Length), generator, 2);
            int[] expected = new int[] {1, 0, 1, 1, 0, 1, 0};
            Assert.AreEqual(expected, actual.Cast<int>().ToArray());
        }
        
    }
}