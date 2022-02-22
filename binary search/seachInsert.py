class Solution:
    def searchInsert(self, nums: List[int], target: int) -> int:
        lowest = 0
        highest = len(nums)
        while lowest<highest:
            middle = lowest + int((highest-lowest)/2)
            if nums[middle] >= target:
                highest = middle 
            else:
                lowest = middle + 1
        return lowest