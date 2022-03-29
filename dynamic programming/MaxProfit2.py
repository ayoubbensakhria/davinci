class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        currentHold, currentNotHold = -sys.maxsize, 0
        for price in prices:
            previousHold, previousNotHold = currentHold, currentNotHold
            currentHold = max(previousHold, previousNotHold - price)
            currentNotHold = max(currentNotHold, previousHold + price)
        return currentNotHold if prices else 0