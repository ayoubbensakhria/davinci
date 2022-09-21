class Solution:
    def coinChange(self, coins: List[int], amount: int) -> int:
        size = amount + 1
        # init list 
        list = [float('inf')] * size
        # set first 0
        list[0] = 0
        
        for i in range(1, size):
            for coin in coins:
                if i-coin >= 0:
                    list[i] = min(list[i], list[i-coin] + 1)
        if list[-1] == float('inf'):
            return -1
        return list[-1]