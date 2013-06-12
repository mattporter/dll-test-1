namespace MathMethods
{
    public class MathStuff
    {
        private static long add_count = 0;
        private static long mult_count = 0;

        public static long add(long i, long j)
        {
            MathStuff.add_count++;
            return (i + j);
        }

        public static long multiply(long x, long y)
        {
            MathStuff.mult_count++;
            return (x * y);
        }

        public static long getAddCount()
        {
            return MathStuff.add_count;
        }

        public static long getMultCount()
        {
            return MathStuff.mult_count;
        }
    }
}