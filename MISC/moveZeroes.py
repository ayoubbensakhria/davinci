class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        pos = 0
        for i in range(len(nums)):
            if nums[i] != 0:
                if i != pos:
                    nums[pos] = nums[i]
                    nums[i] = 0
                pos += 1