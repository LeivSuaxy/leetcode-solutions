public class Solution {
    public int MinimumDeletions(string s)
    {
        int n = s.Length;
        int res = n;
        int countA = 0, countB = 0;

        for (int i = 0; i < n; i++)
        {
            if (s[i] == 'a')
            {
                countA++;
            }
        }

        for (int k = 0; k < n; k++)
        {
            if (s[k] == 'a')
            {
                countA--;
            }

            res = res < countA + countB ? res : countA + countB;
            if (s[k] == 'b')
            {
                countB++;
            }
        }
        
        return res;
    }
}