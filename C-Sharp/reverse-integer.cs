public class Solution {
    public int Reverse(int x)
    {
        if (x == 0)
        {
            return 0;
        }

        if (x > Int32.MaxValue || x < Int32.MinValue) return 0;
        
        if (x / 10 == 0) return x;
        
        int temp;
        bool isFirstNumber = true;
        string final = string.Empty;
        bool isNegative = false;
        long newNumber;

        if (x == Int32.MinValue)
        {
            x = -(x + 1);
            isNegative = true;
        }
        else if (x < 0)
        {
            x = -x;
            isNegative = true;
        }

        while (x > 0)
        {
            temp = x % 10;
            x = x / 10;
            if (isFirstNumber && temp == 0)
            {
                isFirstNumber = false;
                continue;
            }

            final += temp.ToString();
            if (isFirstNumber) isFirstNumber = false;
        }

        newNumber = Int64.Parse(final);

        if (isNegative) newNumber = -newNumber;

        if (newNumber > Int32.MaxValue || newNumber < Int32.MinValue) return 0;

        return (int) newNumber;
    }
}