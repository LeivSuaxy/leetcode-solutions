public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (m == 0)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[i] = nums2[i];
            }
        }
        else
        {

            if (n != 0)
            {
                for (int i = m, j = 0; i < nums1.Length && j < nums2.Length; i++, j++)
                {
                    nums1[i] = nums2[j];
                }

                for (int i = 0; i < nums1.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums1.Length; j++)
                    {
                        if (nums1[j] < nums1[i])
                        {
                            (nums1[i], nums1[j]) = (nums1[j], nums1[i]);
                        }
                    }
                }
            }
        }
    }
}