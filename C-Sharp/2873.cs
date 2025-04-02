namespace DefaultNamespace;

public class Solution {
    public long MaximumTripletValue(int[] nums)
    {
        int n = nums.Length;

        if (n < 3) return 0;
        if (n == 3) return CalculateMax(nums[0], nums[1], nums[2]);

        long max = 0;
        
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    max = Math.Max(max, CalculateMax(nums[i], nums[j], nums[k]));
                }
            }
        }

        return max;
    }

    public long CalculateMax(int num1, int num2, int num3)
    {
        long toReturn = ((long)num1 - num2) * num3;

        if (toReturn < 0) return 0;

        return toReturn;
    } 
}