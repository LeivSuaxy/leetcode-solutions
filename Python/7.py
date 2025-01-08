# Reverse Integer

class Solution:
    def reverse(self, x: int) -> int:
        if x == 0:
            return 0

        string_number: str

        if x > 0:
            string_number = str(x)[::-1]
        else:
            string_number = str(x).removeprefix('-')
            string_number = string_number[::-1]

        new_number: int = int(string_number)

        if new_number > 2**31 - 1 or new_number < -2**31:
            return 0

        if x < 0:
            return new_number * -1

        return new_number



