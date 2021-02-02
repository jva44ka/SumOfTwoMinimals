using System;

namespace SumOfTwoMinimals.App
{
    public class SumFinder
    {
        public int GetSumOfTwoMinimals(int[] array)
        {
            // validation input array
            if (array.Length < 2)
                throw new ArgumentException("Array too short");
            else if (array.Length == 2)
                return array[0] + array[1];

            // min1 always smaller than min2
            int min1 = array[0];
            int min2 = array[1];

            if (min2 > min1)
            {
                var buffer = min1;
                min1 = min2;
                min2 = buffer;
            }

            foreach (var item in array)
            {
                if (item < min1)
                {
                    min2 = min1;
                    min1 = item;
                } else if (item < min2)
                    min2 = item;
            }

            return min1 + min2;
        }
    }
}
