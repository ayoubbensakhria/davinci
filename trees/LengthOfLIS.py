class Solution:
    def lengthOfLIS(self, nums: List[int]) -> int:
        if not nums:
            return 0
        size = len(nums)
        list = [1] * size
        
        for i in range (1, size):
            for j in range (i):
                if nums[i] > nums[j]:
                    list[i] = max(list[i], 1 + list[j])
        return max(list)
            