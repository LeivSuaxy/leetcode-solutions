public class Solution {
    public int FindComplement(int num) {
        char[] binary = Convert.ToString(num, 2).ToCharArray();

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '1') binary[i] = '0';
            else binary[i] = '1';
        }

        string complementBinary = new string(binary);
        return Convert.ToInt32(complementBinary, 2);
    }
}