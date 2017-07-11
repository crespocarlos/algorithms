using console_app.Sorters;
using System;
using System.Linq;

namespace console_app.Strings
{
    public class CharacterChecker
    {
        public bool HasDuplicatedCharater(string word) {
            char[] chars = word.ToCharArray();
            bool[] ascii = new bool[256];
            
            for(int i = 0; i < chars.Length; i++ ) {
                char current = chars[i];
                if (ascii[current] == true) {
                    return true;
                }

                ascii[current] = true;
            }

            return false;

        }
        [Obsolete]
        public bool HasDuplicatedCharater_WorstPerformance(string word) {
            char[] orderedChar = this.SortArray(word.ToCharArray());
            for(int i = 0; i < orderedChar.Length - 1; i++ ) {
                if (orderedChar[i] == orderedChar[i + 1]) {
                    return true;
                }
            }

            return false;

        }

        private char[] SortArray(char[] arr) {
            ISort sorter = new InsertionSort();
            char[] orderedChar = sorter.Sort(arr.Select(p => (int)p).ToArray())
                .Select(p => (char)p)
                .ToArray();

            return orderedChar;
        }
    }
}