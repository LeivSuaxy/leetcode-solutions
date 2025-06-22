// find-first-and-last-position-of-element-in-sorted-array

public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int[] positions = { -1, -1 };
        int arrayLength = nums.Length;
        
        if (nums == null || arrayLength == 0)
            return positions;

        int firstIndex = BinarySearch(nums, target, 0, arrayLength - 1);
        if (firstIndex == -1)
            return positions;
        
        positions[0] = firstIndex;
        positions[1] = firstIndex;
        
        int min = firstIndex - 1;
        int max = firstIndex + 1;
        
        while (max <= arrayLength - 1 && nums[max] == target)
        {
            max++;
        }
        
        while (min >= 0 && nums[min] == target)
        {
            min--;
        }
        
        positions[1] = max - 1;
        positions[0] = min + 1;
        
        return positions;
    }
    
    public int BinarySearch(int[] nums, int target, int left, int right)
    {
        if (left > right)
            return -1;
        
        int middle = left + (right - left) / 2;
        int middleNum = nums[middle];
        if (middleNum == target)
        {
            return middle;
        }

        if (middleNum < target)
        {

            return BinarySearch(nums, target, middle + 1, right);
        } 
        else
        {
            return BinarySearch(nums, target, left, middle - 1);
        }
    }
}