// find-the-original-typed-string-i

public class Solution {
    public int PossibleStringCount(string word) {
        int counter = 1;
        int length = word.Length;

        if (length <= 1) return length;
        
        char currentChar = word[0];

        for (int i = 1; i < length; i++)
        {
            if (currentChar != word[i])
            {
                currentChar = word[i];
            }
            else
            {
                counter++;
            }
        }
        
        return counter;
    }
}