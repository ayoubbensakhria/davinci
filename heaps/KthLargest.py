class KthLargest:

    def __init__(self, k: int, nums: List[int]):
        self.k = k
        # create a list called heap = nums
        self.heap = nums
        # implement priority queue algorithm
        # Transform list nums into a heap, in-place, in linear time.
        # ref: https://docs.python.org/3/library/heapq.html
        # priority queue = add priority
        # The element with the highest value 
        # is considered the highest priority element.
        heapq.heapify(self.heap)
        while len(self.heap) > k:
            # Pop and return the smallest item from the heap
            heapq.heappop(self.heap)

    def add(self, val: int) -> int:
        heapq.heappush(self.heap, val)
        if len(self.heap) > self.k:
            heapq.heappop(self.heap)
        return self.heap[0]
        


# Your KthLargest object will be instantiated and called as such:
# obj = KthLargest(k, nums)
# param_1 = obj.add(val)