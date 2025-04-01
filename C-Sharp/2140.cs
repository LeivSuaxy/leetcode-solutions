namespace DefaultNamespace;

public class Solution {
    public long MostPoints(int[][] questions)
    {
        int n = questions.Length;
        long[] dp = new long[n + 1];
    
        for (int i = n - 1; i >= 0; i--)
        {
            int points = questions[i][0];
            int overheat = questions[i][1];
            
            int nextIndex = Math.Min(i + overheat + 1, n);
       
            dp[i] = Math.Max(points + dp[nextIndex], dp[i + 1]);
        }
    
        return dp[0];
    }
}                
