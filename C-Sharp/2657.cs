// Find the Prefix Common Array of Two Arrays
public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        Dictionary<int, int> keyValues = new Dictionary<int, int>();
        int[] returnArray = new int[A.Length];
        
        for (int i = 0; i < A.Length; i++)
        {
            keyValues.TryAdd(A[i], 1);
            int counter = 0;
            for (int j = 0; j <= i; j++)
            {
                if (keyValues.ContainsKey(B[j]))
                {
                    counter++;
                }
            }

            returnArray[i] = counter;
        }

        return returnArray;
    }
}