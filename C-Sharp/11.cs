public class Solution {
    public int MaxArea(int[] height)
    {
        int medium = height.Length / 2;
        int max = 0;
        int pointerLeft = 0;
        int pointerRigth = height.Length - 1;

        while (pointerLeft != pointerRigth)
        {
            int minIndex = Math.Min(height[pointerLeft], height[pointerRigth]);
            
            int value = (pointerRigth - pointerLeft) * minIndex;

            if (value > max) max = value;

            if (height[pointerLeft] < height[pointerRigth])
            {
                pointerLeft++;
            }
            else
            {
                pointerRigth--;
            }
        }

        return max;
    }
}