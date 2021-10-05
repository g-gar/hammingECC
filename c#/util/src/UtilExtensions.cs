namespace util{
    public static class UtilExtensions{

        public static bool isPowerOf2(this int number)
        {
            ulong x = (ulong) number;
            return ((x != 0) && ((x & (x - 1)) == 0));
        }
        
    }
}