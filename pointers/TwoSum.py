class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        for i in range (len(nums) - 1):
            for j in range (i+1, len(nums)):
                if (nums[i] + nums[j] == target):
                    return [i, j]

##--------------------------------
## Faster solution using dictionary
##--------------------------------
class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        dict = {}
        for i in range (len(nums)):
            if(nums[i] in dict):
                return [dict[nums[i]], i]
            else:
                dict[target-nums[i]] = i
        # if no pairs
        return []