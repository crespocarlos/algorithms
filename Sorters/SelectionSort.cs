using System;

namespace console_app.Sorters
{
    // complexity O(n2)
    public class SelectionSort : ISort {
        
        public int[] Sort(int[] arr) {
            int[] result = new int[arr.Length];
            Array.Copy(arr, result, arr.Length);

            for(int i = 0; i < result.Length; i++) {
                int minIndex = i;
                for(int j = i + 1; j < result.Length; j++) {
                    if (result[minIndex] > result[j]) {
                        minIndex = j;
                    }

                }

                int temp = result[minIndex];
                result[minIndex] = result[i];
                result[i] = temp;
            }

            return result;

        }
    }
}