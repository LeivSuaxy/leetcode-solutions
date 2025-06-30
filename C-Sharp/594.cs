// longest-harmonious-subsequence

public class Solution {
    public int FindLHS(int[] nums)
    {
        List<int> blackList = new List<int>();
        int pivot;
        int max = 0;
        
        
        for (int i = 0; i < nums.Length; i++)
        {
            pivot = nums[i];
            if (blackList.Contains(pivot))
                continue;
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] - pivot == 1 || pivot - nums[j] == 1)
                {
                    blackList.Add(pivot);
                    int coincidences = CountCoincidences(nums, pivot, nums[j]);
                    if (coincidences > max)
                    {
                        max = coincidences;
                    }
                }
            } 

        }

        return max;
    }

    public int CountCoincidences(int[] nums, int pivot, int target)
    {
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == pivot || nums[i] == target)
                count++;
        }

        return count;
    }
}