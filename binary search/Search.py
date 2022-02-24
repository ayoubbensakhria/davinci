class Solution:
    def search(self, nums: List[int], target: int) -> int:
        lowest = 0
        highest = len(nums) - 1
        while lowest<highest:
            middle = lowest + int((highest-lowest)/2)
            if nums[middle] >= nums[highest]:
                if target > nums[middle] or target <= nums[highest]:
                    lowest = middle + 1
                else:
                    highest = middle
            else:
                if target > nums[middle] and target <= nums[highest]:
                    lowest = middle + 1
                else:
                    highest = middle
        if lowest == highest and nums[lowest] != target:
            return -1
        return lowest