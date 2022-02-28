class Solution:
    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
        start_window = 0
        max_length = len(nums)
        result = max_length + 1
        for i in range (max_length):
            target -= nums[i]
            while target<=0:
                result = min(result, i-start_window + 1)
                target += nums[start_window]
                start_window += 1
        return result % (max_length + 1)