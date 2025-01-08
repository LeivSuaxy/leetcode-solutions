from typing import List

class Solution:
    def maxArea(self, height: List[int]) -> int:
        medium: int = int(len(height) / 2)
        max: int = 0
        pointerLeft = 0
        pointerRigth = (len(height)) - 1

        while pointerRigth != pointerLeft:
            min_index = min(height[pointerLeft], height[pointerRigth])
            value = (pointerRigth - pointerLeft) * min_index
            if value > max:
                max = value

            if height[pointerLeft] < height[pointerRigth]:
                pointerLeft += 1
            else:
                pointerRigth -= 1

        return max