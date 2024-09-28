public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 1) return strs[0];

        string prefix = "";
        int index = 0;
        while(index != strs[0].Length)
        {
            char compare = strs[0][index];
            for (int i = 1; i < strs.Count(); i++)
            {
                if(index == strs[i].Count() || strs[i][index] != compare) 
                    return prefix;
            }
            prefix += compare;
            index ++;
        }
        return prefix;
    }
}