using System;
using System.Collections.Generic;

namespace DataStructures.Arrays
{
    class LeftRotation
    {
        public static List<int> RotateLeft(int d, List<int> arr)
        {
            int length = arr.Count;
            List<int> result = new List<int>(new int[length]);

            if(d >= length)
            {
                d = length % d;
            }

            for(int i = 0; i < length; i++)
            {
                // Calculate the index for current element at "i" index

                // If length minus number of moves to the left for current element
                // is less than length
                if(length - d + i < length)
                {
                    int index = length - d + i;

                    result[index] = arr[i];
                }
                // Move current element to the number for number of moves
                else
                {
                    int index = i - d;

                    result[index] = arr[i];
                }
            }

            foreach (int i in result) Console.Write(i + " ");

            return result;
        }
    }
}
