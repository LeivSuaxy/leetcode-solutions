public class Solution {
    public int CountPrefixSuffixPairs(string[] words)
    {
        int counter = 0;
        
        for (int i = 0; i < words.Length - 1; i++)
        {
            for (int j = i + 1; j < words.Length; j++)
            {
                if(!isSmallest(words[i], words[j])) continue;
                if (isPrefix(words[i], words[j]) && isSuffix(words[i], words[j])) counter++;
            }
        }

        return counter;
    }

    public bool isPrefix(string word1, string word2)
    {
        for (int i = 0; i < word1.Length; i++)
        {
            if (word1[i] != word2[i]) return false;
        }

        return true;
    }

    public bool isSuffix(string word1, string word2)
    {
        for (int i = word1.Length-1, j = word2.Length-1; j >= word2.Length - word1.Length; i--, j--)
        {
            if (word1[i] != word2[j]) return false;
        }

        return true;
    }

    public bool isSmallest(string word1, string word2)
    {
        return word1.Length <= word2.Length;
    }
}