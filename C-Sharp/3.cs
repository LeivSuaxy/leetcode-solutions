// Longest substring without repeating characters.

public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        int maxValue = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int counter = 0;
            HashSet<char> hashSet = new HashSet<char>();
            for (int j = i; j < s.Length; j++)
            {
                if (!hashSet.Add(s[j])) break;

                counter++;

                if (counter >= maxValue) maxValue = counter;
            }
        }
        return maxValue;
    }
}