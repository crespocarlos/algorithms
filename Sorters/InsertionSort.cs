using System;

namespace console_app.Sorters
{
    // complexity O(n2)
    public class InsertionSort : ISort, IEmployeeSort {
        public int[] Sort(int[] arr) {
            int[] result = new int[arr.Length];
            Array.Copy(arr, result, arr.Length);

            for(int i = 0; i < result.Length; i++ ) {
                int current = result[i];
                int j = i - 1;

                while (j >= 0 && result[j] > current) {
                    result[j + 1] = result[j];
                    j = j - 1;
                }

                result[j + 1] = current;
            }

            return result;
        }

        public Employee[] Sort(Employee[] arr) {
            Employee[] result = new Employee[arr.Length];
            Array.Copy(arr, result, arr.Length);

            for(int i = 0; i < result.Length; i++ ) {
                Employee current = result[i];
                int j = i - 1;

                while (j >= 0 && result[j].EmployeeNumber > current.EmployeeNumber) {
                    result[j + 1] = result[j];
                    j = j - 1;
                }

                result[j + 1] = current;
            }

            return result;
        }
    }
}