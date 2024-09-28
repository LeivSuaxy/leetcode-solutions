public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] arrayNums = new int[2];
        
        for(int i = 0; i < nums.Length-1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (target - nums[j] == nums[i])
                {
                    arrayNums[0] = i;
                    arrayNums[1] = j;
                    return arrayNums;
                }
            }
        }

        return arrayNums;
    }
}