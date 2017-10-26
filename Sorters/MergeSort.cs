using System;

namespace console_app.Sorters
{
    public class MergeSort : ISort
    {
        public int[] Sort(int[] arr)
        {
            int[] result = new int[arr.Length];
            Array.Copy(arr, result, arr.Length);

            this.Sort(result, 0, arr.Length - 1);
            
            return result;
        }

        private void Sort(int[] arr, int start, int end) {
            if (start < end) {
                int middle = (int)Math.Floor((decimal)(start+end)/2);
                Sort(arr, start, middle);
                Sort(arr, middle + 1, end);
                Merge(arr, start, middle, end);
            }
        }

        private void Merge(int[] arr, int start, int middle, int end) {
            int[] left = new int[(middle - start) + 1];
            int[] right = new int[end - middle];
            int rightIndex = 0;
            int leftIndex = 0;

            for (int i = 0; i < left.Length; i++) {
                left[i] = arr[start + i];
            }

            for (int j = 0; j < right.Length; j++) {
                right[j] = arr[middle + 1 + j];
            }

            for (int i = start; i <= end; i++) {
                if ((rightIndex >= right.Length) || (leftIndex < left.Length && left[leftIndex] <= right[rightIndex])) {
                    arr[i] = left[leftIndex];
                    leftIndex++;
                } else {
                    arr[i] = right[rightIndex];
                    rightIndex++;
                }
            }
        }
    }
}