namespace console_app.Strings
{
    public class Anagram
    {
        public bool IsAnagram(string wordToCompare, string word) {
            if (wordToCompare.Length != word.Length) {
                return false;
            }

            int[] charSet = new int[256];
            int numOfUniqueCharacters = 0;
            int numIterationsOnWord = 0;
            char[] chars = wordToCompare.ToCharArray();

            foreach(var item in chars) {
                if (charSet[(int)item] == 0) {
                    ++numOfUniqueCharacters;
                }

                ++charSet[(int)item];
            }

            for (int i = 0; i < word.Length; i++) {
                int charInt = (int) word[i];

                if (charSet[charInt] == 0) {
                    return false;
                }

                --charSet[charInt];

                if (charSet[charInt] == 0) {
                    ++numIterationsOnWord;
                    if (numIterationsOnWord == numOfUniqueCharacters) {
                        return i == word.Length - 1;
                    }
                }
            }

            return false;
        }
    }
}