// Counting words with a given prefix
public class Solution {
    public int PrefixCount(string[] words, string pref)
    {
        int counter = 0;
        
        foreach (var word in words)
        {
            if (word.StartsWith(pref))
            {
                counter++;
            }
        }

        return counter;
    }
}