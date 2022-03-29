class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        maximum = 0 
        minimum = sys.maxsize
        
        for price in prices:
            minimum = min(price, minimum)
            maximum = max(price - minimum, maximum)
        return maximum