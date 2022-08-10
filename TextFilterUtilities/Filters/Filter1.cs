namespace TextFilterUtilities
{
    public class Filter1 : IFilter1
    {
        public bool IsFilteredWord(string word)
        {
            int wordLength = word.Length;
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'y' };

            var midLetters = wordLength%2 == 0
                ? $"{word[wordLength/2-1]}{word[wordLength/2]}"
                : $"{word[wordLength/2]}";

            return vowels.Any(midLetters.ToLower().Contains);
        }
    }
}
