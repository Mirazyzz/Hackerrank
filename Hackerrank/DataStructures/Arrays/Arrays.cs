namespace DataStructures.Arrays
{
    class Arrays2D
    {
        static int[] ReverseArray(int[] a)
        {
            int length = a.Length;
            // a.Reverse();

            for (int i = 0; i < length / 2; i++)
            {
                int temp = a[i];
                a[i] = a[length - (i + 1)];
                a[length - (i + 1)] = temp;
            }

            return a;
        }
    }
}