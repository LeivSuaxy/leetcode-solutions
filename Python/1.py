# Two Sum
from typing import List

class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        return_list: List[int] = []

        for i in range(len(nums) - 1):
            for j in range(i + 1, len(nums)):
                if target - nums[j] == nums[i]:
                    return_list.append(i)
                    return_list.append(j)
                    return return_list

        return return_list



