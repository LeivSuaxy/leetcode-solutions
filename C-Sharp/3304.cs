//find-the-k-th-character-in-string-game-i

public class Solution {
    public char KthCharacter(int k)
    {
        if (k == 0)
        {
            return 'a';
        }

        string firstString = "a";
        string secondString = String.Empty;
        int counter = 0;
        int stringCounter;

        while (counter < k)
        {
            stringCounter = 0;

            firstString += secondString;
            secondString = String.Empty;
            if (stringCounter >= k)
            {
                return firstString[k - 1];
            }

            counter++;
        }

        return firstString[k-1];
    }
}