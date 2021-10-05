using System.Linq;
using hamming.command;

namespace hamming {
    
    public static class Hamming {

        public static int[] encode(int[] data)
        {
            int parityBitsSize = ComputeParityBitSize.execute(data);
            int[,] generator = CreateGeneratorMatrix.execute(parityBitsSize, data.Length);
            int[,] actual = MultiplyMatrices.execute(ReshapeMatrix.execute(data, 1, data.Length), generator, 2);
            return actual.Cast<int>().ToArray();
        }
        
    }
    
}