class Solution:
    def shipWithinDays(self, weights: List[int], days: int) -> int:
        lowest = max(weights)
        highest = sum(weights)
        while lowest<highest:
            middle = int((highest+lowest)/2)
            currentCapacity = 0
            numberShips = 1
            for weight in weights:
                currentCapacity += weight
                if currentCapacity > middle:
                    currentCapacity = weight
                    numberShips += 1
            if numberShips > days:
                lowest = middle + 1
            else:
                highest = middle
        return lowest