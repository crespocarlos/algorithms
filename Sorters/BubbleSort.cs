using System;

namespace console_app.Sorters
{
    // complexity O(n2)
    public class BubbleSort : ISort
    {
        public int[] Sort(int[] arr) {
            int[] result = new int[arr.Length];
            Array.Copy(arr, result, arr.Length);

            for (int i = 0; i < result.Length - 1; i++) {
                for (int j = 0; j < result.Length - 1 - i; j++) {
                    if (result[j] > result[j + 1]) {
                        int temp = result[j + 1];
                        result[j + 1] = result[j];
                        result[j] = temp;
                    }
                }
            }

            return result;
        }
    }
}