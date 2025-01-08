# Is Palindrome

class Solution:
    def isPalindrome(self, x: int) -> bool:
        string_number = str(x)

        return string_number == string_number[::-1]