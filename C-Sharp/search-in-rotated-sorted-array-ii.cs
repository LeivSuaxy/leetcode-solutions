public class Solution
{
    public bool Search(int[] nums, int target)
    {
        foreach (int number in nums)
        {
            if (number == target) return true;
        }

        return false;
    }
}