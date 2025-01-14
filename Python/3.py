# Longest substring without repeating characters.

class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        max_value = 0
        for i in range(len(s)):
            counter = 0
            hash_set = set()
            for j in range(i, len(s)):
                if s[j] in hash_set:
                    break
                hash_set.add(s[j])
                counter += 1
                if counter >= max_value:
                    max_value = counter
        return max_value
