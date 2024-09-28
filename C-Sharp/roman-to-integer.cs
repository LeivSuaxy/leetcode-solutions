public class Solution {
    public int RomanToInt(string s)
    {
        int result = 0;
        Dictionary<char, int> romans = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int positionReturn = 0;
        int positionSave = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            if (i != s.Length - 1 && (romans[s[i]] < romans[s[i + 1]]))
            {
                positionReturn = i;
                int j = i;
                while (j != s.Length - 1 && (romans[s[j]] < romans[s[j + 1]]))
                {
                    j++;
                }

                positionSave = j;
                while (j > positionReturn)
                {
                    result += romans[s[j]] - romans[s[j-1]];
                    j--;
                }

                i = positionSave;
            }
            else
            {
                result += romans[s[i]];
            }
        }
        return result;
    }
}