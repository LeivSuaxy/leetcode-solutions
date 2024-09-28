public class Solution {
    public bool IsValid(string s)
    {
        Dictionary<char, char> parentheses = new Dictionary<char, char>()
        {
            { '[', ']' },
            { '{', '}' },
            { '(', ')' }
        };
        Stack<char> stack = new Stack<char>();

        foreach (var chr in s)
        {
            if (parentheses.ContainsKey(chr))
            {
                stack.Push(chr);
            }

            if (parentheses.ContainsValue(chr))
            {
                if (stack.Count > 0)
                {
                    if (parentheses[stack.Peek()] != chr)
                    {
                        return false;
                    }

                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }

        return stack.Count <= 0;
    }
}