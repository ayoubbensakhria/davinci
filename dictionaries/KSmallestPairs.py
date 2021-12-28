class Solution:
    def kSmallestPairs(self, nums1: List[int], nums2: List[int], k: int) -> List[List[int]]:
        
        heap = []
        heapq.heapify(heap)
                
        for n in range (min(len(nums1), k)):
            for m in range (min(len(nums2), k)):
                heapq.heappush(heap, (nums1[n] + nums2[m], nums1[n], nums2[m]))       
        return (q[1:] for q in heapq.nsmallest(k, heap))