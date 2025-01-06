public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int pointer1 = 0;
        int pointer2 = 0;
        int k = 0;
        while (pointer1 < nums.Length)
        {
            while (pointer2 < nums.Length)
            {
                if (nums[pointer1] != nums[pointer2])
                {
                    pointer1++;
                    nums[pointer1] = nums[pointer2];
                }

                pointer2++;
            }

            k = pointer1 + 1;
            break;
        }

        return k;
    }
}