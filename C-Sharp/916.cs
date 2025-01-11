// Word Subsets

public class Solution {
    public IList<string> WordSubsets(string[] words1, string[] words2)
    {
        Dictionary<char, int> requirements = counterRequirements(words2);
        
        List<string> universalwords = new List<string>();

        foreach (var word in words1)
        {
            if (isUniversal(word, requirements))
            {
                universalwords.Add(word);
            }
        }
        
        return universalwords;
    }

    private Dictionary<char, int> counterWords(string word)
    {
        Dictionary<char, int> returned = new Dictionary<char, int>();

        for (int i = 0; i < word.Length; i++)
        {
            if (returned.ContainsKey(word[i]))
            {
                returned[word[i]]++;
            }
            else
            {
                returned[word[i]] = 1;
            }
        }

        return returned;
    }

    private Dictionary<char, int> counterRequirements(string[] words2)
    {
        Dictionary<char, int> requirements = new Dictionary<char, int>();

        foreach (var word in words2)
        {
            Dictionary<char, int> counter = counterWords(word);

            foreach (var kvp in counter)
            {
                if (!requirements.ContainsKey(kvp.Key))
                {
                    requirements[kvp.Key] = kvp.Value;
                }
                else
                {
                    requirements[kvp.Key] = Math.Max(requirements[kvp.Key], kvp.Value);
                }
            }
        }

        return requirements;
    }

    private bool isUniversal(string word, Dictionary<char, int> requirements)
    {
        Dictionary<char, int> counterWord = counterWords(word);
        
        foreach (var kvp in requirements)
        {
            if (!counterWord.ContainsKey(kvp.Key) || counterWord[kvp.Key] < kvp.Value)
            {
                return false;
            }
        }
        
        return true;
    }
}