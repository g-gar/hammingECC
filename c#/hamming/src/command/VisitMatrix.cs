using System;
using System.Data;

namespace hamming.command{
    public class VisitMatrix{
        public static T[,] execute<T>(int rows, int columns, Func<int, int, T> fn)
        {
            T[,] result = new T[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = fn(i, j);
                }
            }

            return result;
        }
    }
}