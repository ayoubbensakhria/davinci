class Solution:
    def rob(self, nums: List[int]) -> int:
        if len(nums) == 0:
            return 0
        if len(nums) == 1:
            return nums[0]
        previousRobbed, currentRobbed, previousNotRobbed, currentNotRobbed = 0, 0, 0, 0
        
        for i in range(len(nums)-1):
            tempNotRobbed = previousNotRobbed
            previousNotRobbed = currentNotRobbed
            currentNotRobbed = max(tempNotRobbed + nums[i], previousNotRobbed)
            
            tempRobbed = previousRobbed
            previousRobbed = currentRobbed
            currentRobbed = max(tempRobbed + nums[i+1], previousRobbed)
        return max(currentRobbed, currentNotRobbed)