using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays
{
    class DynamicArray
    {
        public static List<int> Dynamic(int n, List<List<int>> queries)
        {
            List<List<int>> dArr = new List<List<int>>();
            List<int> result = new List<int>();
            int lastAnswer = 0;

            // Initialize sub "arrays"
            for (int i = 0; i < n; i++)
            {
                dArr.Add(new List<int>());
            }

            foreach (List<int> query in queries)
            {
                // Get the index of element in the array
                // for current iteration
                int idx = ((query[1] ^ lastAnswer) % n);

                if (query[0] == 1)
                {
                    // Append "y" to the sublist at index "idx"
                    dArr[idx].Add(query[2]);
                }
                else
                {
                    // Get value of lastAnswer from sublist under index
                    // found from formula
                    lastAnswer = dArr[idx][query[2] % dArr[idx].Count];

                    result.Add(lastAnswer);
                }
            }

            return result;
        }
    }
}