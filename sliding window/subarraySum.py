class Solution:
    def subarraySum(self, nums: List[int], k: int) -> int:
        counter = 0
        # sliding window
        # iterate and calculate the sum total at the same time
        # increment the counter everytime the condition is satisfied
        for i in range (len(nums)):
            total = 0
            for j in range (i, len(nums)):
                total += nums[j]
                if(total == k):
                    counter +=1
        return counter