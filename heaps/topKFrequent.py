class Solution(object):
    def topKFrequent(self, nums, k):
        # Collections.Counter counts instances of each value
        # and returns a dictionary
        num_count = collections.Counter(nums)
        # example: ({1: 3, 2: 2, 3: 1})
        # Use lambda to return keys after heapq.nlargest 
        # returns the largest values
        return heapq.nlargest(k, num_count, key=lambda x: num_count[x])