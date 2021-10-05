using System;
using System.Linq;
using hamming;

namespace console{
    class Program {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                int[] data = arg.ToArray().Select(c => c - '0').ToArray();
                Console.WriteLine(string.Join("", Hamming.encode(data)));
            }
        }
    }
}