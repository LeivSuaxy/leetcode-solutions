// Minimum Length of String After Operations
public class Solution {
    public int MinimumLength(string s)
    {
        Dictionary<char, int> chars = counterWords(s);
        int length = s.Length;
        
        foreach (var kvp in chars)
        {
            if (kvp.Value >= 3)
            {
                int repetitions = 0;
                if (kvp.Value % 2 == 0)
                {
                    repetitions = (kvp.Value - 2) / 2;
                }
                else
                {
                    repetitions = (kvp.Value - 1) / 2;
                }
                
                length -= repetitions * 2;
            }
        }
        return length;
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
}