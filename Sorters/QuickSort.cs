using System;

namespace console_app.Sorters
{
    public class QuickSort : ISort
    {
        public int[] Sort(int[] arr)
        {
            int[] result = new int[arr.Length];
            Array.Copy(arr, result, arr.Length);

            this.Sort(result, 0, arr.Length - 1);
            
            return result;
        }

        private void Sort(int[] arr, int start, int end) {
            if (start > end) {
                return;
            }

            var pivot = this.Partition(arr, start, end);
            this.Sort(arr, start, pivot-1);
            this.Sort(arr, pivot+1, end);
        }

        public int Partition(int[] arr, int start, int end) {
            var pivot = arr[end];
            var i = start;

            for (int j = start; j < end; j++)
            {
                if (arr[j] <= pivot) {
                    this.Swap(arr, i, j);
                    i++;
                }

            }

            this.Swap(arr, i, end);
            return i;
        }

        private void Swap(int[] arr, int from, int to) {
            var temp = arr[from];
            arr[from] = arr[to];
            arr[to] = temp;
        }
    }
}