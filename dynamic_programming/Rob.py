class Solution:
    def rob(self, nums: List[int]) -> int:
        previous, current = 0, 0
        for num in nums:
            temp = max(previous+num, current)
            previous = current
            current = temp
        return current