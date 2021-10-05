using System;

namespace hamming.command{
    public class ReshapeMatrix{
        public static int[,] execute(int[] flat, int m, int n)
        {
            if (flat.Length != m * n)
            {
                throw new ArgumentException("Invalid length");
            }
            int[,] ret = new int[m, n];
            // BlockCopy uses byte lengths: a double is 8 bytes
            Buffer.BlockCopy(flat, 0, ret, 0, flat.Length * sizeof(int));
            return ret;
        }
    }
}