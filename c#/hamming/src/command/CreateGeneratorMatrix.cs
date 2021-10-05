using util;

namespace hamming.command{
    public class CreateGeneratorMatrix {

        public static int[,] execute(int parityBitSize, int dataLength)
        {
            int rows = dataLength;
            int columns = parityBitSize + rows;
            int[,] result = new int[rows,columns];
            int counter = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j < parityBitSize)
                    {
                        result[i, j] = i == j ? 0 : 1;
                    }
                    else
                    {
                        result[i, j] = i == (j-parityBitSize) ? 1 : 0;
                    }
                }
            }
            
            return result;
        }
    }
}