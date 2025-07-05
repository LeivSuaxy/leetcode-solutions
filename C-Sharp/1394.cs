//find-lucky-integer-in-an-array

public class Solution {
    public int FindLucky(int[] arr)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (dict.ContainsKey(arr[i]))
            {
                dict[arr[i]]++;
            }
            else
            {
                dict.Add(arr[i], 1);
            }
        }

        int lucky = -1;
        
        foreach (var kvp in dict)
        {
            if (kvp.Key == kvp.Value)
            {
                if (kvp.Key > lucky)
                {
                    lucky = kvp.Key;
                }
            }
        }
        
        return lucky;
    }
}