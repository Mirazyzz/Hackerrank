using DataStructures.Arrays;
using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> query = new List<List<int>>
            {
                new List<int>
                {
                    1,
                    0,
                    5
                },
                new List<int>
                {
                    1,
                    1,
                    7
                },
                new List<int>
                {
                    1,
                    0,
                    3
                },
                new List<int>
                {
                    2,
                    1,
                    0
                },
                new List<int>
                {
                    2,
                    1,
                    1
                },
            };

            DynamicArray.Dynamic(2, query);

        }
    }
}
