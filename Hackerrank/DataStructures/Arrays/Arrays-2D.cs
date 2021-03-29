namespace DataStructures.Arrays
{
    class Arrays2D
    {
        static int HourglassSum(int[][] arr)
        {
            int currentSum = 0;
            int max = int.MinValue;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr[i].Length - 2; j++)
                {
                    currentSum += arr[i][j];
                    currentSum += arr[i][j + 1];
                    currentSum += arr[i][j + 2];
                    currentSum += arr[i + 1][j + 1];
                    currentSum += arr[i + 2][j];
                    currentSum += arr[i + 2][j + 1];
                    currentSum += arr[i + 2][j + 2];

                    if (currentSum > max) max = currentSum;
                    currentSum = 0;
                }
            }

            return max;
        }
    }
}
