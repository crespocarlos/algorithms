using System;

namespace console_app.Sorters
{
    public class CountingSort : ISort
    {
        public int[] Sort(int[] arr)
        {
            int[] result = new int[arr.Length];
            Array.Copy(arr, result, arr.Length);

            var arrNumbers = new int[11];
            
            for (int i = 0; i < result.Length; i++)
            {
                arrNumbers[result[i]] = arrNumbers[result[i]] + 1;
            }

            int curr = 0;

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                for (int j = 0; j < arrNumbers[i]; j++)
                {
                    result[curr] = i;
                    curr++;
                    
                }
                
            }

            return result;
        }
    }
}