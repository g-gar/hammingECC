using System.Linq;
using System.Xml.XPath;

namespace hamming.command{
    public class MultiplyMatrices{

        public static int[,] execute(int[,] m1, int[,] m2)
        {
            return execute(m1, m2, 10);
        }

        public static int[,] execute(int[,] m1, int[,] m2, int modulus = 10)
        {
            return VisitMatrix.execute(m1.GetLength(0), m2.GetLength(1), (i, j) =>
                Enumerable.Range(0, m1.GetLength(1)-1)
                    .Select(k => m1[i, k] * m2[k, j])
                    .Aggregate(0, (a, b) => (a + b), e => e % modulus)
            );
        }
    }
}