class Solution:
    def nextPermutation(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        def swap(nums:List[int], i, j) -> None:
            temp = 0
            temp = nums[i]
            nums[i] = nums[j]
            nums[j] = temp
        
        def reverseSort(nums:List[int], start, end) -> None:
            if start > end: 
                return
            for i in range (start, int((start+end)/2)+1):
                swap(nums, i, start+end - i)
        
        n = len(nums)
        if n<2:
            return
        index = n-1
        while index > 0:
            if nums[index-1] < nums[index]:
                break
            index -= 1
        if index == 0:
            reverseSort(nums, 0, n-1)
            return
        else:
            val = nums[index-1]
            j = n-1
            while j >= index:
                if nums[j]>val:
                    break
                j -= 1
            swap(nums, j, index-1)
            reverseSort(nums, index, n-1)
            return