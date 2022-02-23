class Solution:
    def findMin(self, nums: List[int]) -> int:
        lowest = 0
        highest = len(nums) - 1
        while lowest<highest:
            middle = int((highest + lowest)/2)
            if nums[middle] > nums[highest]:
                lowest = middle + 1
            else:
                highest = middle
        return nums[lowest]