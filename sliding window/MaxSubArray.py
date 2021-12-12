class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        sum = 0
        min_sum = 0
        result = nums[0]
        for i in range (len(nums)):
            min_sum = min(min_sum, sum) if (i > 0) else 0
            sum += nums[i]
            result = max(sum-min_sum, result)
        return result