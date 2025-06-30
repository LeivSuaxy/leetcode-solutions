//zigzag-conversion

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }
        
        int space = numRows - 2;
        int length = s.Length;

        if (length == 1)
        {
            return s;
        }
        
        string returnString = string.Empty;
        int level = 0;
        

        while (level < numRows)
        {
            if (level == 0 || level == numRows - 1)
            {
                for (int i = level; i < length; i = (i + numRows + space))
                {
                    returnString += s[i];
                }
            }
            else
            {
                int i = level;
                bool longPart = true;
                while (i < length)
                {
                    returnString += s[i];
                    if (longPart)
                    {
                        i += numRows + space - 2 * level;
                    }
                    else
                    {
                        i += 2 * level;
                    }

                    longPart = !longPart;
                }
            }
            level++;
        }
        
        return returnString;
    }
}