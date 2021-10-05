using hamming.command;
using NUnit.Framework;

namespace test{
    public class GeneratePacketTests {
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int[,] actual = CreateGeneratorMatrix.execute(2, 1);
            int[,] expected = new int[,] {{0, 1, 1}};
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Test4a()
        {
            int[,] actual = CreateGeneratorMatrix.execute(3, 2);
            int[,] expected = new int[,] {{0, 1, 1, 1, 0}, {1, 0, 1, 0, 1}};
            Assert.AreEqual(expected, actual);
        }
        
    }
}