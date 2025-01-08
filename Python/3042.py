# Count Prefix And Suffix Pairs I

from typing import List

class Solution:
    def countPrefixSuffixPairs(self, words: List[str]) -> int:
        counter: int = 0

        for i in range(len(words) - 1):
            for j in range(i+1 ,len(words)):
                if len(words[i]) > len(words[j]):
                    continue

                if words[j].startswith(words[i]) and words[j].endswith(words[i]):
                    counter += 1

        return counter



