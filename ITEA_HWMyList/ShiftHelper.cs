using System;
using System.Collections.Generic;
using System.Text;

namespace ListExamples
{
    public class Shift
    {
        public static void RightShift(ref int[] array, int lowerLimitint, int upperLimit)
        {
            for (int i = upperLimit; i > lowerLimitint; i--)
            {
                array[i] = array[i - 1];
            }
        }

        public static void LeftShift(ref int[] array, int lowerLimitint, int upperLimit)
        {
            for (int i = lowerLimitint; i < upperLimit; i++)
            {
                array[i] = array[i + 1];
            }
        }
    }
}
