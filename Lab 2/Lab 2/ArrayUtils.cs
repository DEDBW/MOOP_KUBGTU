using System;
namespace STLab01
{
    public class ArrayUtils
    {
        public static int Min(int[] a)
        {
            if (a == null)
            if (a == null)
                throw new
               ArgumentException("Ошибка. В метод передан пустой массив.");
            int min = a[0];
            foreach (int x in a)
            {
                if (min > x)
                    min = x;
            }
            return min;
        }
        public static int Max(int[] a)
        {
            if (a == null)
                throw new
               ArgumentException("Ошибка. В метод передан пустой массив.");
            int max = a[0];
            foreach (int x in a)
            {
                if (max < x)
                    max = x;
            }
            return max;
        }
    }
}