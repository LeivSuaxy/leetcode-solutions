public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
        {
            return false;
        }

        if (x == 0)
        {
            return true;
        }

        string number = x.ToString();
        string reverse = string.Empty;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            reverse += number[i];
        }
        
        return number == reverse;
    }
}