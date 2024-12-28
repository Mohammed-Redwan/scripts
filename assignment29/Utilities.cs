using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
namespace assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public static string RepeatString(this string toRepeat, int iterations)
        {
            string returnedString = "";
            for (int i = 1; i <= iterations; i++)
            {
                if (i == iterations)
                {
                    returnedString += toRepeat;
                }
                else
                {
                    returnedString += toRepeat + " ";
                }
            }
            return returnedString;
        }
    }
}