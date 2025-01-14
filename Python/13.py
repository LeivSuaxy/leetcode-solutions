# Roman To Integer

class Solution:
    def romanToInt(self, s: str) -> int:
        result = 0
        romans = {
            'I': 1,
            'V': 5,
            'X': 10,
            'L': 50,
            'C': 100,
            'D': 500,
            'M': 1000
        }

        position_return = 0
        position_save = 0

        for i in range(len(s)):
            if i != len(s) - 1 and (romans[s[i]] < romans[s[i + 1]]):
                position_return = i
                j: int = i
                while j != len(s) - 1 and (romans[s[j]] < romans[s[j + 1]]):
                    j += 1

                position_save = j
                while j > position_return:
                    result += romans[s[j]] - romans[s[j-1]]
                    j -= 1

                i = position_save
            else:
                result += romans[s[i]]
        return result
