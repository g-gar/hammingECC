using System;

namespace hamming.command{
    public class ComputeParityBitSize {
        public static int execute(int[] arg)
        {
            int result = -1;
            int m = arg.Length;
            while (m + result + 1 > Math.Pow(2, result))
            {
                result += 1;
            }
            return result;
        }
    }
}