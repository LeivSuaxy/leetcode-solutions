namespace DefaultNamespace;

public class Solution
{
    public int MinLength(string s) {
        if (s.Length == 0) return 0;

        string cadena1 = "AB", cadena2 = "CD";

        while (s.Contains(cadena1) || s.Contains(cadena2))
        {
            s = s.Replace(cadena1, "").Replace(cadena2, "");
        }

        return s.Length;
    }
}