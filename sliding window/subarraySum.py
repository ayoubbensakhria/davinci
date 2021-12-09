# ----------------------------------------------------------------
# Sliding window solution O(N^2)
# ----------------------------------------------------------------
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
# ----------------------------------------------------------------
# Dictionary solution O(N)
# ----------------------------------------------------------------
class Solution:
    def subarraySum(self, nums: List[int], k: int) -> int:
        counter = 0
        total = 0
        dict = {}
        # total 0 = 1
        dict[0] = 1
        # sum[i] - sum[j] = k => sum[j] = sum[i] - k
        # sliding window
        for i in range (len(nums)):
            total += nums[i]
            if((total-k) in dict):
                counter += dict[total-k]
            # save cumulative sums with the count of instances
            if((total) in dict):
                dict[total] += 1
            else:
                dict[total] = 1
        return counter